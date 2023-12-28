using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.People;

public class PersonExternalIds
{
    [JsonProperty("imdb_id")] public string? ImdbId { get; set; }

    [JsonProperty("facebook_id")] public string? FacebookId { get; set; }

    [JsonProperty("freebase_mid")] public string? FreebaseMid { get; set; }

    [JsonProperty("freebase_id")] public string? FreebaseId { get; set; }

    [JsonProperty("tvrage_id")] public int? TvrageId { get; set; }

    [JsonProperty("twitter_id")] public string? TwitterId { get; set; }

    [JsonProperty("id")] public int Id { get; set; }
}