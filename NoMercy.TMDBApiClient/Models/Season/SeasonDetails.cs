using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Episode;

namespace NoMercy.TMDBApi.Models.Season;

public class SeasonDetails : Season
{
    [JsonProperty("episodes")] public EpisodeDetails[] Episodes { get; set; } = Array.Empty<EpisodeDetails>();
}