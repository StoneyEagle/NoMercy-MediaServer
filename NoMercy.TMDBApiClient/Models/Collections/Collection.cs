using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Collections;

public class Collection
{
    public Collection(int id, string name, string posterPath, string backdropPath)
    {
        Id = id;
        Name = name;
        PosterPath = posterPath;
        BackdropPath = backdropPath;
    }

    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("poster_path")] public string PosterPath { get; set; }

    [JsonProperty("backdrop_path")] public string BackdropPath { get; set; }
}