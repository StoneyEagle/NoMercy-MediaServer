using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Season;

public class SeasonAggregatedCredits
{
    [JsonProperty("id")] public int Id { get; set; }
    
    [JsonProperty("cast")] public AggregatedCast[] Cast { get; set; } = Array.Empty<AggregatedCast>();

    [JsonProperty("crew")] public AggregatedCrew[] Crew { get; set; } = Array.Empty<AggregatedCrew>();
}