using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Web;
using Newtonsoft.Json;

namespace NoMercy.Server.Helpers;

public static class Auth
{
    private static readonly string BaseUrl = "https://auth-dev2.nomercy.tv/realms/NoMercyTV";
    private static readonly string AuthBaseUrl = $@"{BaseUrl}";
    private static readonly string TokenUrl = $@"{AuthBaseUrl}/protocol/openid-connect/token";
    
    private static string? PublicKey { set; get; }
    private static string? TokenClientId { set; get; } = "nomercy-server";
    private static string? TokenClientSecret { set; get; } = "1lHWBazSTHfBpuIzjAI6xnNjmwUnryai";

    private static string? RefreshToken { set; get; }
    public static string? AccessToken { private set; get; }
    private static int? ExpiresIn { get; set; }
    private static string? IdToken { get; set; }

    private static IWebHost? TempServer { get; set; }

    public static void Init()
    {
        if(!File.Exists(AppFiles.TokenFile))
        { 
            File.WriteAllText(AppFiles.TokenFile, "{}");
        }
        
        AccessToken = GetAccessToken();
        RefreshToken = GetRefreshToken();
        ExpiresIn = GetTokenExpiration();
        IdToken = GetIdToken();
        
        GetAuthKeys();
        
        if(AccessToken != null && RefreshToken != null && ExpiresIn != null && IdToken != null)
            GetTokenByRefreshGrand();
        else
            GetTokenByBrowser();
        
        if (AccessToken == null || RefreshToken == null || ExpiresIn == null || IdToken == null)
            throw new Exception("Failed to get tokens");
        
    }

    private static void GetTokenByBrowser()
    {
        string redirectUri =HttpUtility.UrlEncode(@$"http://localhost:" + Networking.InternalServerPort + "/sso-callback");
        string url = "https://auth-dev2.nomercy.tv/realms/NoMercyTV/protocol/openid-connect/auth?redirect_uri=" +
                     redirectUri + "&client_id=nomercy-server&response_type=code&scope=openid%20offline_access";

        TempServer = Networking.TempServer();
        TempServer.StartAsync().Wait();
        
        OpenBrowser(url);
        
        CheckToken();
    }

    private static void CheckToken()
    {
        Task.Run(async () =>
        {
            await Task.Delay(1000);

            if (AccessToken == null || RefreshToken == null || ExpiresIn == null || IdToken == null)
                CheckToken();
            else
                TempServer?.StopAsync().Wait();
        }).Wait();
    }

    private static void SetTokens(string response)
    {
        dynamic data = JsonConvert.DeserializeObject(response) 
                       ?? throw new Exception("Failed to deserialize JSON");
        
        if (data.access_token == null || data.refresh_token == null || data.expires_in == null || data.id_token == null)
        {
            throw new Exception("Failed to get authentication tokens");
        }

        File.WriteAllText(AppFiles.TokenFile, JsonConvert.SerializeObject(data, Formatting.Indented));
        Console.WriteLine(@"Tokens refreshed");
        
        AccessToken = data.access_token;
        RefreshToken = data.refresh_token;
        IdToken = data.id_token;
        ExpiresIn = data.expires_in;
    }
    private static dynamic GetTokenData()
    {
        return JsonConvert.DeserializeObject(File.ReadAllText(AppFiles.TokenFile))
               ?? throw new Exception("Failed to deserialize JSON");
    }

    private static string? GetAccessToken()
    {
        return null;
        dynamic data = GetTokenData();
        return data.access_token;
    }

    private static string? GetRefreshToken() {
        dynamic data = GetTokenData();
        return data.refresh_token;
    }

    private static string? GetIdToken() {
        dynamic data = GetTokenData();
        return data.id_token;
    }

    private static int? GetTokenExpiration() {
        dynamic data = GetTokenData();
        return data.expires_in;
    }

    private static void GetAuthKeys()
    {
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        string response = client.GetStringAsync(AuthBaseUrl).Result;
        
        dynamic data = JsonConvert.DeserializeObject(response) 
                       ?? throw new Exception("Failed to deserialize JSON");
        
        PublicKey = data.public_key;
        
    }
    
    private static void GetTokenByPasswordGrant(string username, string password)
    {
        if (TokenClientId == null || TokenClientSecret == null)
            throw new Exception("Auth keys not initialized");
        
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        
        var body = new List<KeyValuePair<string, string>>()
        {
            new ("grant_type", "password"),
            new ("client_id", TokenClientId),
            new ("client_secret", TokenClientSecret),
            new ("username", username),
            new ("password", password),
        };
        
        string response = client.PostAsync(TokenUrl, new FormUrlEncodedContent(body))
            .Result.Content.ReadAsStringAsync().Result;
        
        SetTokens(response);
    }
    private static void GetTokenByRefreshGrand()
    {
        if (TokenClientId == null || TokenClientSecret == null || RefreshToken == null)
            throw new Exception("Auth keys not initialized");
        
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        
        var body = new List<KeyValuePair<string, string>>()
        {
            new ("grant_type", "refresh_token"),
            new ("client_id", TokenClientId),
            new ("client_secret", TokenClientSecret),
            new ("refresh_token", RefreshToken),
            new ("scope", "openid offline_access"),
        };
        
        string response = client.PostAsync(TokenUrl,new FormUrlEncodedContent(body))
            .Result.Content.ReadAsStringAsync().Result;
        
        SetTokens(response);
    }
    public static void GetTokenByAuthorizationCode(string code)
    {
        if (TokenClientId == null || TokenClientSecret == null)
            throw new Exception("Auth keys not initialized");
        
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        
        var body = new List<KeyValuePair<string, string>>()
        {
            new ("grant_type", "authorization_code"),
            new ("client_id", TokenClientId),
            new ("client_secret", TokenClientSecret),
            new ("scope", "openid offline_access"),
            new ("redirect_uri", $"http://localhost:{Networking.InternalServerPort}/sso-callback"),
            new ("code", code),
        };
        
        string response = client.PostAsync(TokenUrl, new FormUrlEncodedContent(body))
            .Result.Content.ReadAsStringAsync().Result;
        
        SetTokens(response);
    }
    
    private static void OpenBrowser(string url)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true }); // Works ok on windows
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            Process.Start("xdg-open", url);  // Works ok on linux
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            Process.Start("open", url); // Not tested
        }
        else
        {
            throw new Exception("Unsupported OS");
        }
    }
}