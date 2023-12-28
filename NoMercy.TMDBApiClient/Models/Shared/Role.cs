using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Shared;

public class Role
{
    [JsonProperty("credit_id")] public string CreditId { get; set; }

    [JsonProperty("character")] public string Character { get; set; }

    [JsonProperty("episode_count")] public int EpisodeCount { get; set; }
}