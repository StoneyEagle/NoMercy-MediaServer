using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Combined;

public class CombinedTranslations
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("translations")] public CombinedTranslation[] Translations { get; set; } = Array.Empty<CombinedTranslation>();
}

public class CombinedTranslation
{
    [JsonProperty("iso_3166_1")] public string Iso31661 { get; set; } = string.Empty;

    [JsonProperty("iso_639_1")] public string Iso6391 { get; set; } = string.Empty;

    [JsonProperty("name")] public string Name { get; set; } = string.Empty;

    [JsonProperty("english_name")] public string EnglishName { get; set; } = string.Empty;

    [JsonProperty("data")] public CombinedTranslationData Data { get; set; } = new();
}

public class CombinedTranslationData
{
    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("title")] public string? Title { get; set; }

    [JsonProperty("overview")] public string? Overview { get; set; }

    [JsonProperty("homepage")] public Uri Homepage { get; set; } = null!;

    [JsonProperty("biography")] public string? Biography { get; set; }

    [JsonProperty("tagline")] public string? Tagline { get; set; }
}