using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Shared;

public class PaginatedResponse<T>
{
    [JsonProperty("page")] public int Page { get; set; }

    [JsonProperty("results")] public T[] Results { get; set; } = Array.Empty<T>();

    [JsonProperty("total_pages")] public int TotalPages { get; set; }

    [JsonProperty("total_results")] public int TotalResults { get; set; }
}