using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Episode;

public class ExternalIds
{
    [JsonProperty("imdb_id")] public string? ImdbId { get; set; }

    [JsonProperty("freebase_mid")] public string? FreebaseMid { get; set; }

    [JsonProperty("freebase_id")] public string? FreebaseId { get; set; }

    [JsonProperty("tvrage_id")] public int? TvRageId { get; set; }

    [JsonProperty("id")] public int Id { get; set; }
}