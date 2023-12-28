using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Networks;

public class NetworkDetails : Network
{
    [JsonProperty("headquarters")] public string Headquarters { get; set; } = string.Empty;

    [JsonProperty("homepage")] public Uri? Homepage { get; set; }
}