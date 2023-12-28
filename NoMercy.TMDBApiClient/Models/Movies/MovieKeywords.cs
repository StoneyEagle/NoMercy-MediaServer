using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Movies;

public class MovieKeywords : SharedKeywords
{
    [JsonProperty("keywords")] public override Keyword[]? Results { get; set; } = Array.Empty<Keyword>();
}