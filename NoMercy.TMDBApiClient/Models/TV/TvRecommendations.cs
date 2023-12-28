using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.TV;

public class TvRecommendations : PaginatedResponse<RecommendationsTvShow>
{
}

public class RecommendationsTvShow : TvShow
{
    [JsonProperty("adult")] public bool Adult { get; set; }
}