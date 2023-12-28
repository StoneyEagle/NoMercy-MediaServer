using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Movies;

public class MovieCertifications
{
    [JsonProperty("results")] public CertificationsResult[] Results { get; set; } = Array.Empty<CertificationsResult>();
}

public class CertificationsResult
{
    [JsonProperty("iso_3166_1")] public string Iso31661 { get; set; } = string.Empty;

    [JsonProperty("rating")] public string Rating { get; set; } = string.Empty;
}