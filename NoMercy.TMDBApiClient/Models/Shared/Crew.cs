using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Shared;

public class Crew
{
    [JsonProperty("department")] public string? Department { get; set; }

    [JsonProperty("job")] public string Job { get; set; } = null!;

    [JsonProperty("credit_id")] public string CreditId { get; set; } = string.Empty;

    [JsonProperty("adult")] public bool Adult { get; set; }

    [JsonProperty("gender")] public int Gender { get; set; }

    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("known_for_department")] public string? KnownForDepartment { get; set; }

    [JsonProperty("name")] public string Name { get; set; } = string.Empty;

    [JsonProperty("original_name")] public string OriginalName { get; set; } = string.Empty;

    [JsonProperty("popularity")] public float Popularity { get; set; } = 0;

    [JsonProperty("profile_path")] public string? ProfilePath { get; set; }

    [JsonProperty("order")] public int? Order { get; set; }

    [JsonProperty("character")] public string Character { get; set; } = string.Empty;
}