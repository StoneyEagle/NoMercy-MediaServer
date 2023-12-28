using Newtonsoft.Json;

namespace NoMercy.Server;

public partial class ApiInfo
{
    public static readonly string ApplicationVersion = Environment.Version.ToString();

    public static async Task RequestInfo()
    {
        var client = new HttpClient();
        var response = await client.GetAsync("https://api.nomercy.tv/v1/info");
        var content = await response.Content.ReadAsStringAsync();
        
        var data = JsonConvert.DeserializeObject<ApiInfo>(content);
        
        if (data == null) throw new Exception("Failed to get server info");

        Startup.ApiInfo = data;
    }
}

#region Types
public partial class ApiInfo
{
    [JsonProperty("status")]
    public string Status { get; set; } = string.Empty;

    [JsonProperty("data")]
    public Data Data { get; set; }  = new ();
}

public class Data
{
    [JsonProperty("state")]
    public string State { get; set; } = string.Empty;

    [JsonProperty("version")]
    public string Version { get; set; } = string.Empty;

    [JsonProperty("copyright")]
    public string Copyright { get; set; } = string.Empty;

    [JsonProperty("licence")]
    public string Licence { get; set; } = string.Empty;

    [JsonProperty("contact")]
    public Contact Contact { get; set; } = new ();

    [JsonProperty("git")]
    public Uri? Git { get; set; }

    [JsonProperty("keys")]
    public Keys Keys { get; set; } = new ();

    [JsonProperty("quote")]
    public string Quote { get; set; } = string.Empty;

    [JsonProperty("colors")]
    public string[] Colors { get; set; } = Array.Empty<string>();

    [JsonProperty("downloads")]
    public Downloads Downloads { get; set; } = new ();
}

public class Contact
{
    [JsonProperty("homepage")]
    public string Homepage { get; set; } = string.Empty;

    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("email")]
    public string Email { get; set; } = string.Empty;

    [JsonProperty("dmca")]
    public string Dmca { get; set; } = string.Empty;

    [JsonProperty("languages")]
    public string Languages { get; set; } = string.Empty;

    [JsonProperty("socials")]
    public Socials Socials { get; set; } = new ();
}

public class Socials
{
    [JsonProperty("twitch")]
    public Uri? Twitch { get; set; }

    [JsonProperty("youtube")]
    public Uri? Youtube { get; set; }

    [JsonProperty("twitter")]
    public Uri? Twitter { get; set; }

    [JsonProperty("discord")]
    public string Discord { get; set; } = string.Empty;
}

public class Downloads
{
    [JsonProperty("windows")]
    public List<Download> Windows { get; set; } = [];

    [JsonProperty("linux")]
    public List<Download> Linux { get; set; } = [];

    [JsonProperty("mac")]
    public List<Download> Mac { get; set; } = [];
}

public class Download
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("path")]
    public string Path { get; set; } = string.Empty;

    [JsonProperty("url")]
    public Uri? Url { get; set; }

    [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
    public string Filter { get; set; } = string.Empty;
}

public class Keys
{
    [JsonProperty("makemkv_key")]
    public string MakeMkvKey { get; set; } = string.Empty;

    [JsonProperty("tmdb_key")]
    public string TmdbKey { get; set; } = string.Empty;

    [JsonProperty("omdb_key")]
    public string OmdbKey { get; set; } = string.Empty;

    [JsonProperty("fanart_key")]
    public string FanArtKey { get; set; } = string.Empty;

    [JsonProperty("rotten_tomatoes")]
    public string RottenTomatoes { get; set; } = string.Empty;

    [JsonProperty("acoustic_id")]
    public string AcousticId { get; set; } = string.Empty;
}
#endregion