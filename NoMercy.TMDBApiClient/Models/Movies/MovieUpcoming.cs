using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Movies;

public class MovieUpcoming : PaginatedResponse<Movie>
{
    [JsonProperty("dates")] public UpcomingDates Dates { get; set; } = new();
}

public class UpcomingDates
{
    [JsonProperty("maximum")] public DateTime? Maximum { get; set; }

    [JsonProperty("minimum")] public DateTime? Minimum { get; set; }
}