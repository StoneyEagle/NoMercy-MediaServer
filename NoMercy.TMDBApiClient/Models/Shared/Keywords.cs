using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Shared;

public class SharedKeywords
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("results")] public virtual Keyword[]? Results { get; set; }
}

public class Keyword
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}