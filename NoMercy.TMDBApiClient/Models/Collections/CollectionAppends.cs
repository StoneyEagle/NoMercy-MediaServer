using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Combined;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Collections;

public class CollectionAppends : CollectionDetails
{
    public CollectionAppends(Ci images, CombinedTranslations translations) : base(0, "", "", "", "", Array.Empty<Movies.Movie>())
    {
        Images = images;
        Translations = translations;
    }

    [JsonProperty("images")] public Ci Images { get; set; }

    [JsonProperty("translations")] public CombinedTranslations Translations { get; set; }
}

public class Ci
{
    public Ci(Backdrop[] backdrops, Poster[] posters)
    {
        Backdrops = backdrops;
        Posters = posters;
    }

    [JsonProperty("backdrops")] public Backdrop[] Backdrops { get; set; }

    [JsonProperty("posters")] public Poster[] Posters { get; set; }
}