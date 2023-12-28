using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Networks;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.TV;

public class TvShowDetails : TvShow
{
    [JsonProperty("adult")] public bool Adult { get; set; }

    [JsonProperty("created_by")] public CreatedBy[] CreatedBy { get; set; }

    [JsonProperty("episode_run_time")] public int[] EpisodeRunTime { get; set; }

    [JsonProperty("genres")] public Genre[] Genres { get; set; }

    [JsonProperty("homepage")] public Uri Homepage { get; set; }

    [JsonProperty("in_production")] public bool InProduction { get; set; }

    [JsonProperty("languages")] public string[] Languages { get; set; }

    [JsonProperty("last_episode_to_air")] public Episode.Episode LastEpisodeToAir { get; set; }

    [JsonProperty("next_episode_to_air")] public Episode.Episode NextEpisodeToAir { get; set; }

    [JsonProperty("networks")] public Network[] Networks { get; set; }

    [JsonProperty("number_of_episodes")] public int NumberOfEpisodes { get; set; }

    [JsonProperty("number_of_seasons")] public int NumberOfSeasons { get; set; }

    [JsonProperty("production_companies")] public Network[] ProductionCompanies { get; set; }

    [JsonProperty("production_countries")] public ProductionCountry[] ProductionCountries { get; set; }

    [JsonProperty("seasons")] public Season.Season[] Seasons { get; set; }

    [JsonProperty("spoken_languages")] public SpokenLanguage[] SpokenLanguages { get; set; }

    [JsonProperty("status")] public string Status { get; set; }

    [JsonProperty("tagline")] public string Tagline { get; set; }

    [JsonProperty("type")] public string Type { get; set; }
}