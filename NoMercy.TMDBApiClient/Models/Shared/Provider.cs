using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Shared;

public class Provider
{
    [JsonProperty("display_priority")] public int DisplayPriority { get; set; }

    [JsonProperty("logo_path")] public string LogoPath { get; set; }

    [JsonProperty("provider_name")] public string ProviderName { get; set; }

    [JsonProperty("provider_id")] public int ProviderId { get; set; }
}