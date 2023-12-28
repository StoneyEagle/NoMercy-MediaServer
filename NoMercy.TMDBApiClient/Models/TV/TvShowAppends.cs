using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Combined;

namespace NoMercy.TMDBApi.Models.TV;

public class TvShowAppends : TvShowDetails
{
    [JsonProperty("aggregate_credits")] public TvAggregatedCredits? AggregateCredits { get; set; }

    [JsonProperty("alternative_titles")] public TvAlternativeTitles? AlternativeTitles { get; set; }

    [JsonProperty("content_ratings")] public TvContentRatings? ContentRatings { get; set; }

    [JsonProperty("credits")] public TvCredits? Credits { get; set; }

    [JsonProperty("external_ids")] public TvExternalIds? ExternalIds { get; set; }

    [JsonProperty("images")] public TvImages? Images { get; set; }

    [JsonProperty("keywords")] public TvKeywords? Keywords { get; set; }

    [JsonProperty("recommendations")] public TvRecommendations? Recommendations { get; set; }

    [JsonProperty("similar")] public TvSimilar? Similar { get; set; }

    [JsonProperty("translations")] public CombinedTranslations? Translations { get; set; }

    [JsonProperty("videos")] public TvVideos? Videos { get; set; }

    [JsonProperty("watch/providers")] public WatchProviders? WatchProviders { get; set; }
}