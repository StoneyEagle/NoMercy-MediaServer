using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Collections;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.Movies;

public class MovieDetails : Movie
{
    [JsonProperty("belongs_to_collection")]
    public Collection? BelongsToCollection { get; set; }

    [JsonProperty("budget")] public int Budget { get; set; }

    [JsonProperty("genres")] public Genre[] Genres { get; set; } = { };

    [JsonProperty("homepage")] public Uri? Homepage { get; set; }

    [JsonProperty("imdb_id")] public string? ImdbId { get; set; }

    [JsonProperty("production_companies")] public ProductionCompany[] ProductionCompanies { get; set; } = { };

    [JsonProperty("production_countries")] public ProductionCountry[] ProductionCountries { get; set; } = { };

    [JsonProperty("release_date")] public DateTime? ReleaseDate { get; set; }

    [JsonProperty("revenue")] public long Revenue { get; set; }

    [JsonProperty("runtime")] public int Runtime { get; set; }

    [JsonProperty("spoken_languages")] public SpokenLanguage[] SpokenLanguages { get; set; } = { };

    [JsonProperty("status")] public string? Status { get; set; }

}