using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Shared;

public class Genre
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; } = string.Empty;
}