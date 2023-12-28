using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Genres;

public class GenreTv
{
    [JsonProperty("genres")] public Genre[] Genres { get; set; } = Array.Empty<Genre>();
}