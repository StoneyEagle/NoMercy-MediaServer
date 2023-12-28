using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Shared;

public class AggregatedCredit
{
    [JsonProperty("adult")] public bool Adult { get; set; }

    [JsonProperty("gender")] public int Gender { get; set; }

    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("known_for_department")] public string? KnownForDepartment { get; set; }

    [JsonProperty("name")] public string Name { get; set; } = string.Empty;

    [JsonProperty("original_name")] public string OriginalName { get; set; } = string.Empty;

    [JsonProperty("popularity")] public float Popularity { get; set; }

    [JsonProperty("profile_path")] public string? ProfilePath { get; set; }

    [JsonProperty("order")] public int Order { get; set; }
}

public class AggregatedCrew : AggregatedCredit
{
    [JsonProperty("jobs")] public Jobs[] Jobs { get; set; } = Array.Empty<Jobs>();
}

public class Roles
{
    [JsonProperty("credit_id")] public string CreditId { get; set; } = string.Empty;

    [JsonProperty("character")] public string Character { get; set; } = string.Empty;

    [JsonProperty("episode_count")] public int EpisodeCount { get; set; }
}

public class AggregatedCast : AggregatedCredit
{
    [JsonProperty("roles")] public Roles[] Roles { get; set; } = Array.Empty<Roles>();
}

public class Jobs
{
    [JsonProperty("credit_id")] public string CreditId { get; set; } = string.Empty;

    [JsonProperty("job")] public string Job { get; set; } = string.Empty;

    [JsonProperty("episode_count")] public int EpisodeCount { get; set; }
}