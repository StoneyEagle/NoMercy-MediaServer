using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.WatchProviders;

public class MovieProviders
{
    [JsonProperty("results")] public Provider[] Results { get; set; } = Array.Empty<Provider>();
}