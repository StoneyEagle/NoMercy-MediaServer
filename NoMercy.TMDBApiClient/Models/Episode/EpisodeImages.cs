using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Episode;

public class Images
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("stills")] public Still[] Stills { get; set; } = Array.Empty<Still>();
}