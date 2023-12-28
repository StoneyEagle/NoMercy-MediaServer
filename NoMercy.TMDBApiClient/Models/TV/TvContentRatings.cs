using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.TV;

public class TvContentRatings
{
    [JsonProperty("results")] public ContentRatingsResult[] Results { get; set; }
}

public class ContentRatingsResult
{
    [JsonProperty("iso_3166_1")] public string Iso31661 { get; set; }

    [JsonProperty("rating")] public string Rating { get; set; }
}