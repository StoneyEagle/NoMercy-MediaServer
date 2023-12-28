using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.People;

public class PersonTranslations
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("translations")] public Translation[] Translations { get; set; } = Array.Empty<Translation>();
}

public class Translation
{
    [JsonProperty("iso_639_1")] public string Iso6391 { get; set; } = string.Empty;

    [JsonProperty("iso_3166_1")] public string Iso31661 { get; set; } = string.Empty;

    [JsonProperty("name")] public string Name { get; set; } = string.Empty;

    [JsonProperty("data")] public Data Data { get; set; } = new();

    [JsonProperty("english_name")] public string EnglishName { get; set; } = string.Empty;
}

public class Data
{
    [JsonProperty("biography")] public string Overview { get; set; } = string.Empty;
}