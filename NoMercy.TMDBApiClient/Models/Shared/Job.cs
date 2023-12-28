using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Shared;

public class Job
{
    [JsonProperty("credit_id")] public string CreditId { get; set; }

    [JsonProperty("job")] public string JobJob { get; set; }

    [JsonProperty("episode_count")] public int EpisodeCount { get; set; }
}