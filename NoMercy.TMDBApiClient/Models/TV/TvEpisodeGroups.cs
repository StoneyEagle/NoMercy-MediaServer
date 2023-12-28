using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Networks;

namespace NoMercy.TMDBApi.Models.TV;

public class TvEpisodeGroups
{
    [JsonProperty("results")] public EpisodeGroupsResult[] Results { get; set; }

    [JsonProperty("id")] public int Id { get; set; }
}

public class EpisodeGroupsResult
{
    [JsonProperty("description")] public string Description { get; set; }

    [JsonProperty("episode_count")] public int EpisodeCount { get; set; }

    [JsonProperty("group_count")] public int GroupCount { get; set; }

    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("network")] public Network Network { get; set; }

    [JsonProperty("type")] public int Type { get; set; }
}

public class EpisodeGroupsResultNetwork
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("logo_path")] public string LogoPath { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("origin_country")] public string OriginCountry { get; set; }
}