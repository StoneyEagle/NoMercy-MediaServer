using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Search;

public class Companies : PaginatedResponse<CompanyResult>
{
}

public class CompanyResult
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("logo_path")] public string? LogoPath { get; set; }

    [JsonProperty("name")] public string Name { get; set; } = string.Empty;
}