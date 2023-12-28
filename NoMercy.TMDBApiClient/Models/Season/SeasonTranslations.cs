using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Season;

public class SeasonTranslations : SharedTranslations
{
    [JsonProperty("translations")] public new SeasonTranslation[] Translations { get; set; } = Array.Empty<SeasonTranslation>();
}

public class SeasonTranslation : SharedTranslation
{
    [JsonProperty("data")] public new SeasonTranslationData Data { get; set; } = new();
}

public class SeasonTranslationData : SharedTranslationData
{
    [JsonProperty("name")] public string Name { get; set; } = string.Empty;
}