using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Combined;

namespace NoMercy.TMDBApi.Models.Episode;

public class EpisodeAppends : EpisodeDetails
{
    [JsonProperty("credits")] public Credits? Credits { get; set; }

    [JsonProperty("changes")] public EpisodeChanges? Changes { get; set; }

    [JsonProperty("external_ids")] public ExternalIds? ExternalIds { get; set; }

    [JsonProperty("images")] public Images? Images { get; set; }

    [JsonProperty("translations")] public CombinedTranslations? Translations { get; set; }

    [JsonProperty("videos")] public Videos? Videos { get; set; }
}