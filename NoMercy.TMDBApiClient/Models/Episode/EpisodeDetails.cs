using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Episode;

public class EpisodeDetails : Episode
{
    [JsonProperty("crew")] public Crew[] Crew { get; set; } = Array.Empty<Crew>();

    [JsonProperty("cast")] public Cast[] Cast { get; set; } = Array.Empty<Cast>();

    [JsonProperty("guest_stars")] public GuestStar[] GuestStars { get; set; } = Array.Empty<GuestStar>();
}