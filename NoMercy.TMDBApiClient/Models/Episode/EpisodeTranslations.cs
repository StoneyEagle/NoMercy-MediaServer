using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Episode;

public class EpisodeTranslations : SharedTranslations
{
    [JsonProperty("translations")] public new EpisodeTranslation[] Translations { get; set; } = Array.Empty<EpisodeTranslation>();
}

public class EpisodeTranslation : SharedTranslation
{

    [JsonProperty("data")] public new EpisodeTranslationData Data { get; set; } = new();
}

public class EpisodeTranslationData : SharedTranslationData
{
    [JsonProperty("name")] public string Name { get; set; } = string.Empty;
}