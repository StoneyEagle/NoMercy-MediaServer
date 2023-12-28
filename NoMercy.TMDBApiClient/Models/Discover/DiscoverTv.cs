using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Discover;

public class DiscoverTv
{

    [JsonProperty("page")] public int Page { get; set; }

    [JsonProperty("results")] public Result[] Results { get; set; } = Array.Empty<Result>();

    [JsonProperty("total_results")] public int TotalResults { get; set; }

    [JsonProperty("total_pages")] public int TotalPages { get; set; }
}

public class Result
{
    [JsonProperty("poster_path")] public string? PosterPath { get; set; }

    [JsonProperty("popularity")] public double Popularity { get; set; }

    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("backdrop_path")] public object? BackdropPath { get; set; }

    [JsonProperty("vote_average")] public double VoteAverage { get; set; }

    [JsonProperty("overview")] public string? Overview { get; set; }

    [JsonProperty("first_air_date")] public DateTime FirstAirDate { get; set; }

    [JsonProperty("origin_country")] public string[]? OriginCountry { get; set; }

    [JsonProperty("genre_ids")] public int[] GenreIds { get; set; } = Array.Empty<int>();

    [JsonProperty("original_language")] public string? OriginalLanguage { get; set; }

    [JsonProperty("vote_count")] public int VoteCount { get; set; } = 0;

    [JsonProperty("name")] public string Name { get; set; } = string.Empty;

    [JsonProperty("original_name")] public string OriginalName { get; set; } = string.Empty;
}