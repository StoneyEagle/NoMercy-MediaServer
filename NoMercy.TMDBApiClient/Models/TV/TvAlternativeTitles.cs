using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.TV;

public class TvAlternativeTitles
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("results")] public TvAlternativeTitle[] Results { get; set; }
}

public class TvAlternativeTitle
{
    [JsonProperty("title")] public string Title { get; set; }

    [JsonProperty("iso_3166_1")] public string Iso31661 { get; set; }
}