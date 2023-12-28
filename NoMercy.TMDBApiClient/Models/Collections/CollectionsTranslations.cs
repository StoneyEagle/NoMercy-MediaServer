using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Collections;

public class CollectionsTranslations : SharedTranslations
{
    public CollectionsTranslations(CollectionsTranslation[] translations)
    {
        Translations = translations;
    }

    [JsonProperty("translations")] public new CollectionsTranslation[] Translations { get; set; }
}

public class CollectionsTranslation : SharedTranslation
{
    [JsonProperty("data")] public new CollectionsTranslationData Data { get; set; } = new();
}

public class CollectionsTranslationData : SharedTranslationData
{
    [JsonProperty("title")] public string Title { get; set; } = string.Empty;
}