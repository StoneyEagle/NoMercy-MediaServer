using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Movies;

public class MovieVideos
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("results")] public Video[] Results { get; set; } = Array.Empty<Video>();
}