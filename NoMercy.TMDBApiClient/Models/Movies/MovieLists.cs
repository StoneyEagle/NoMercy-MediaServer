using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Movies;

public class MovieLists : PaginatedResponse<Movie>
{
    [JsonProperty("id")] public int Id { get; set; }

}