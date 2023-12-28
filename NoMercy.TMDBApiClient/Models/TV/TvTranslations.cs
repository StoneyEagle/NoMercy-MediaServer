using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.TV;

public class TvTranslations : SharedTranslations
{
    [JsonProperty("translations")] public new TvTranslation[] Translations { get; set; }
}

public class TvTranslation : SharedTranslation
{
    [JsonProperty("data")] public new TvTranslationData Data { get; set; }
}

public class TvTranslationData : SharedTranslationData
{
    [JsonProperty("name")] public string Name { get; set; }
}