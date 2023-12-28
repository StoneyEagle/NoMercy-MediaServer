using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace NoMercy.Server.Helpers;

public static class Register
{
    public static Task Init()
    {
        var serverData = new Dictionary<string, string>
        {
            {"server_id", SystemInfo.DeviceId},
            {"server_name", SystemInfo.DeviceName},
            {"internal_ip", Networking.InternalIp},
            {"internal_port", Networking.InternalServerPort.ToString()},
            {"external_port", Networking.ExternalServerPort.ToString()},
            {"server_version", ApiInfo.ApplicationVersion},
            {"platform", SystemInfo.Platform}
        };
        
        Console.WriteLine(@"Registering server, this takes a moment...");
        
        var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        
        var content = client.PostAsync("https://api-dev2.nomercy.tv/v1/server/register", new FormUrlEncodedContent(serverData))
            .Result.Content.ReadAsStringAsync().Result;
        
        var data = JsonConvert.DeserializeObject(content);
        
        if (data == null) throw new Exception("Failed to register server");
        
        Console.WriteLine(@"Server registered successfully");
        
        AssignServer().Wait();
        
        return Task.CompletedTask;
    }

    private static Task AssignServer()
    {
        var serverData = new Dictionary<string, string>
        {
            {"server_id", SystemInfo.DeviceId}
        };
        
        var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Auth.AccessToken);

        var content = client.PostAsync("https://api-dev2.nomercy.tv/v1/server/assign", new FormUrlEncodedContent(serverData))
            .Result.Content.ReadAsStringAsync().Result;
        
        var data = JsonConvert.DeserializeObject<ServerRegisterResponse>(content);
        
        if (data == null) throw new Exception("Failed to assign server");
        
        Console.WriteLine(@"Server assigned successfully");
        
        Certificate.RenewSslCertificate().Wait();
        
        return Task.CompletedTask;
    }
}

public class ServerRegisterResponse
{
}