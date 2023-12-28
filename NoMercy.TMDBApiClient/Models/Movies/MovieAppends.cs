using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Combined;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Movies;

public class MovieAppends : MovieDetails
{
    [JsonProperty("alternative_titles")] public MovieAlternativeTitles? AlternativeTitles { get; set; }

    [JsonProperty("certifications")] public MovieCertifications? Certifications { get; set; }

    [JsonProperty("credits")] public MovieCredits? Credits { get; set; }

    [JsonProperty("external_ids")] public MovieExternalIds? ExternalIds { get; set; }

    [JsonProperty("images")] public MovieImages? Images { get; set; }

    [JsonProperty("keywords")] public MovieKeywords? Keywords { get; set; }

    [JsonProperty("recommendations")] public MovieRecommendations? Recommendations { get; set; }

    [JsonProperty("similar")] public MovieSimilar? Similar { get; set; }

    [JsonProperty("translations")] public CombinedTranslations? MovieTranslations { get; set; }

    [JsonProperty("videos")] public MovieVideos? Videos { get; set; }

    [JsonProperty("watch/providers")] public MovieWatchProviders? WatchProviders { get; set; }

    [JsonProperty("genres")] public new Genre[]? Genres { get; set; }

    [JsonProperty("release_dates")] public MovieReleaseDates? ReleaseDates { get; set; }

}