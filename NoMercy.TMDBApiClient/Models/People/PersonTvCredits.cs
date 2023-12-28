using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.People;

public class PersonTvCredits
{
    [JsonProperty("id")] public int Id { get; set; }
    
    [JsonProperty("cast")] public Cast[] Cast { get; set; } = Array.Empty<Cast>();

    [JsonProperty("crew")] public Crew[] Crew { get; set; } = Array.Empty<Crew>();
}