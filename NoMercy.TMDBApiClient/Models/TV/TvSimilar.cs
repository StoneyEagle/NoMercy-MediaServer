using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.TV;

public class TvSimilar : PaginatedResponse<SimilarTvShow>
{
}

public class SimilarTvShow : TvShow
{
    [JsonProperty("adult")] public bool Adult { get; set; }
}