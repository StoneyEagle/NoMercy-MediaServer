using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Movies;

public class MovieTranslations : SharedTranslations
{
    [JsonProperty("translations")] public new MovieTranslation[] Translations { get; set; } = Array.Empty<MovieTranslation>();
}

public class MovieTranslation : SharedTranslation
{
    [JsonProperty("data")] public new MovieTranslationData Data { get; set; } = new();
}

public class MovieTranslationData : SharedTranslationData
{
    [JsonProperty("title")] public string Title { get; set; } = string.Empty;
}