using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Movies;
using NoMercy.TMDBApi.Models.People;
using NoMercy.TMDBApi.Models.TV;

namespace NoMercy.TMDBApi.Models.Find;

public class FindById
{
    [JsonProperty("movie_results")] public Movie[] MovieResults { get; set; } = Array.Empty<Movie>();

    [JsonProperty("person_results")] public Person[] PersonResults { get; set; } = Array.Empty<Person>();

    [JsonProperty("tv_results")] public TvShow[] TvResults { get; set; } = Array.Empty<TvShow>();

    [JsonProperty("tv_episode_results")] public Episode.Episode[] TvEpisodeResults { get; set; } = Array.Empty<Episode.Episode>();

    [JsonProperty("tv_season_results")] public Season.Season[] TvSeasonResults { get; set; } = Array.Empty<Season.Season>();
}