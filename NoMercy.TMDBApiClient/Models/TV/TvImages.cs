using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.TV;

public class TvImages
{
    [JsonProperty("backdrops")] public Backdrop[] Backdrops { get; set; }

    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("posters")] public Poster[] Posters { get; set; }
}