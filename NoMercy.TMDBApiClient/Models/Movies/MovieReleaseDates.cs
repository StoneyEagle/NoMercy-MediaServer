using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Movies;

public class MovieReleaseDates
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("results")] public Result[] Results { get; set; } = { };
}

public class Result
{
    [JsonProperty("iso_3166_1")] public string Iso31661 { get; set; } = string.Empty;

    [JsonProperty("release_dates")] public ReleaseDate[] ReleaseDates { get; set; } = Array.Empty<ReleaseDate>();
}

public class ReleaseDate
{
    [JsonProperty("certification")] public string Certification { get; set; } = string.Empty;

    [JsonProperty("iso_639_1")] public string Iso6391 { get; set; } = string.Empty;

    [JsonProperty("release_date")] public DateTime ReleaseDateReleaseDate { get; set; } = DateTime.MinValue;

    [JsonProperty("type")] public int Type { get; set; }

    [JsonProperty("note")] public string? Note { get; set; }
}