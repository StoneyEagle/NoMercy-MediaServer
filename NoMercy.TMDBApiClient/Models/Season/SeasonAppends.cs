using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Combined;

namespace NoMercy.TMDBApi.Models.Season;

public class SeasonAppends : SeasonDetails
{
    [JsonProperty("aggregate_credits")] public SeasonAggregatedCredits AggregateCredits { get; set; } = new();

    [JsonProperty("changes")] public SeasonChanges? Changes { get; set; }

    [JsonProperty("credits")] public Credits Credits { get; set; } = new();

    [JsonProperty("external_ids")] public ExternalIds ExternalIds { get; set; } = new();

    [JsonProperty("images")] public Images Images { get; set; } = new();

    [JsonProperty("translations")] public CombinedTranslations Translations { get; set; } = new();

    [JsonProperty("videos")] public Videos Videos { get; set; } = new();
}