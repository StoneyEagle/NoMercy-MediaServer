using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.TV;

public class TvShow
{
    [JsonProperty("backdrop_path")] public string? BackdropPath { get; set; }

    [JsonProperty("first_air_date")] public DateTime? FirstAirDate { get; set; }

    [JsonProperty("genre_ids")] public int[] GenreIds { get; set; } = { };

    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; } = string.Empty;

    [JsonProperty("origin_country")] public string[] OriginCountry { get; set; } = { };

    [JsonProperty("original_language")] public string OriginalLanguage { get; set; } = string.Empty;

    [JsonProperty("original_name")] public string OriginalName { get; set; } = string.Empty;

    [JsonProperty("overview")] public string? Overview { get; set; }

    [JsonProperty("popularity")] public float Popularity { get; set; }

    [JsonProperty("poster_path")] public string? PosterPath { get; set; }

    [JsonProperty("type")] public string MediaType { get; set; } = string.Empty;

    [JsonProperty("vote_average")] public float VoteAverage { get; set; } = 0;

    [JsonProperty("vote_count")] public int VoteCount { get; set; } = 0;
}