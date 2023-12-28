using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Movies;

public class MovieNowPlaying : PaginatedResponse<Movie>
{
    [JsonProperty("dates")] public Dates Dates { get; set; } = new();
}

public class Dates
{
    [JsonProperty("maximum")] public DateTime? Maximum { get; set; }

    [JsonProperty("minimum")] public DateTime? Minimum { get; set; }
}