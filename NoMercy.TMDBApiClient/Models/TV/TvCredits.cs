using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.TV;

public class TvCredits
{
    [JsonProperty("cast")] public Cast[] Cast { get; set; }

    [JsonProperty("crew")] public Crew[] Crew { get; set; }

    [JsonProperty("id")] public int Id { get; set; }
}