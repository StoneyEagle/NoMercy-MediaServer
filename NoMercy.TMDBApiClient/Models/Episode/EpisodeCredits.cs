using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Episode;

public class Credits
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("cast")] public Cast[] Cast { get; set; } = Array.Empty<Cast>();

    [JsonProperty("crew")] public Crew[] Crew { get; set; } = Array.Empty<Crew>();

    [JsonProperty("guest_stars")] public GuestStar[] GuestStars { get; set; } = Array.Empty<GuestStar>();
}