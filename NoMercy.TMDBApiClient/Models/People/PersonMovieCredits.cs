using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.People;

public class PersonMovieCredits
{
    [JsonProperty("id")] public int Id { get; set; }
    
    [JsonProperty("cast")] public Cast[] Cast { get; set; } = Array.Empty<Cast>();

    [JsonProperty("crew")] public Cast[] Crew { get; set; } = Array.Empty<Cast>();
}