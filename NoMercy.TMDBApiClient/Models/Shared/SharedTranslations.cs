using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Shared;

public class SharedTranslations
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("translations")] public SharedTranslation[] Translations { get; set; }
}

public class SharedTranslation
{
    [JsonProperty("iso_3166_1")] public string Iso31661 { get; set; }

    [JsonProperty("iso_639_1")] public string Iso6391 { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("english_name")] public string EnglishName { get; set; }

    [JsonProperty("data")] public SharedTranslationData Data { get; set; }
}

public class SharedTranslationData
{
    [JsonProperty("overview")] public string Overview { get; set; }

    [JsonProperty("homepage")] public Uri Homepage { get; set; }

    [JsonProperty("tagline")] public string Tagline { get; set; }
}