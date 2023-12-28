using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.TV;

public class TvChanges
{
    [JsonProperty("key")] public string Key { get; set; }

    [JsonProperty("items")] public Item[] Items { get; set; }
}

public class Item
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("action")] public Action Action { get; set; }

    [JsonProperty("time")] public string Time { get; set; }

    [JsonProperty("value")] public string? Value { get; set; }

    [JsonProperty("iso_639_1")] public string Iso6391 { get; set; }

    [JsonProperty("original_value")] public string? OriginalValue { get; set; }
}

public class OriginalValueClass
{
    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("credit_id")] public string CreditId { get; set; }

    [JsonProperty("person_id")] public int? PersonId { get; set; }

    [JsonProperty("season_id")] public int? SeasonId { get; set; }

    [JsonProperty("poster")] public Poster Poster { get; set; }

    [JsonProperty("department")] public string Department { get; set; }

    [JsonProperty("job")] public string Job { get; set; }
}

public class ValueClass
{
    [JsonProperty("season_id")] public int? SeasonId { get; set; }

    [JsonProperty("season_number")] public int? SeasonNumber { get; set; }

    [JsonProperty("id")] public int? Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("add_to_every_season")] public bool? AddToEverySeason { get; set; }

    [JsonProperty("character")] public string Character { get; set; }

    [JsonProperty("credit_id")] public string CreditId { get; set; }

    [JsonProperty("order")] public int? Order { get; set; }

    [JsonProperty("person_id")] public int? PersonId { get; set; }

    [JsonProperty("poster")] public Poster Poster { get; set; }

    [JsonProperty("department")] public string Department { get; set; }

    [JsonProperty("job")] public string Job { get; set; }
}