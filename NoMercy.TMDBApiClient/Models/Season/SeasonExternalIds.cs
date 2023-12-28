using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Season;

public class ExternalIds
{
    [JsonProperty("id")] public int Id { get; set; }
    
    [JsonProperty("freebase_mid")] public string? FreebaseMid { get; set; }

    [JsonProperty("freebase_id")] public object? FreebaseId { get; set; }

    [JsonProperty("tvdb_id")] public int? TvdbId { get; set; }

    [JsonProperty("tvrage_id")] public string? TvrageId { get; set; }
}