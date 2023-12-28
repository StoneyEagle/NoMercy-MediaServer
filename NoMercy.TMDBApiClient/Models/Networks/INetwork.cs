using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Networks;

public class Network
{
    [JsonProperty("name")] public string Name { get; set; } = string.Empty;

    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("logo_path")] public string LogoPath { get; set; } = string.Empty;

    [JsonProperty("origin_country")] public string OriginCountry { get; set; } = string.Empty;
}