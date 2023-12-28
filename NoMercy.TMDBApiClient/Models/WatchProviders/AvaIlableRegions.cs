using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.WatchProviders;

public class AvailableRegions
{
    [JsonProperty("results")] public AvailableRegionsResult[] Results { get; set; } = Array.Empty<AvailableRegionsResult>();
}

public class AvailableRegionsResult
{
    [JsonProperty("iso_3166_1")] public string Iso31661 { get; set; } = string.Empty;

    [JsonProperty("english_name")] public string EnglishName { get; set; } = string.Empty;

    [JsonProperty("native_name")] public string? NativeName { get; set; }
}