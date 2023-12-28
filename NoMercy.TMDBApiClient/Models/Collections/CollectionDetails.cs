using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Collections;

public class CollectionDetails : Collection
{
    public CollectionDetails(int id, string name, string posterPath, string backdropPath, string overview, Movies.Movie[] parts) : base(id, name, posterPath, backdropPath)
    {
        Overview = overview;
        Parts = parts;
    }

    [JsonProperty("overview")] public string Overview { get; set; }

    [JsonProperty("parts")] public Movies.Movie[] Parts { get; set; }
}