using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Season;

public class Images
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("posters")] public Poster[] Posters { get; set; } = Array.Empty<Poster>();
}