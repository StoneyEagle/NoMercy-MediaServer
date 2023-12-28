using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Search;

public class Collections : PaginatedResponse<CollectionResult>
{
}

public class CollectionResult
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("backdrop_path")] public string? BackdropPath { get; set; }

    [JsonProperty("name")] public string Name { get; set; } = string.Empty;

    [JsonProperty("poster_path")] public string? PosterPath { get; set; }
}