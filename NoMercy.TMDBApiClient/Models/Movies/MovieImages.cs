using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Movies;

public class MovieImages
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("backdrops")] public Backdrop[] Backdrops { get; set; } = Array.Empty<Backdrop>();

    [JsonProperty("posters")] public Poster[] Posters { get; set; } = Array.Empty<Poster>();
}