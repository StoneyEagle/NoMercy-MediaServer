using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.TV;

public class TvAggregatedCredits
{
    [JsonProperty("cast")] public AggregatedCast[] Cast { get; set; }

    [JsonProperty("crew")] public AggregatedCrew[] Crew { get; set; }

    [JsonProperty("id")] public int Id { get; set; }
}