using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.TV;

public class TvScreenedTheatrically
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("results")] public ScreenedTheatricallyResult[] Results { get; set; }
}

public class ScreenedTheatricallyResult
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("episode_number")] public int EpisodeNumber { get; set; }

    [JsonProperty("season_number")] public int SeasonNumber { get; set; }
}