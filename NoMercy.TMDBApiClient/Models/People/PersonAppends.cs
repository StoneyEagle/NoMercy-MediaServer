using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.People;

public class PersonAppends : PersonDetails
{
    [JsonProperty("air_date")] public DateTime AirDate { get; set; }

    [JsonProperty("details")] public PersonDetails Details { get; set; } = new();

    [JsonProperty("movie_credits")] public PersonMovieCredits MovieCredits { get; set; } = new();

    [JsonProperty("tv_credits")] public PersonTvCredits TvCredits { get; set; } = new();

    [JsonProperty("external_ids")] public PersonExternalIds ExteralIds { get; set; } = new();

    [JsonProperty("images")] public PersonImages Images { get; set; } = new();

    [JsonProperty("translations")] public PersonTranslations Translations { get; set; } = new();
}