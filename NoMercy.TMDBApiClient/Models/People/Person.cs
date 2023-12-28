using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.People;

public enum Gender
{
    Unknown = 0,
    Male = 1,
    Female = 2,
    NonBinary = 3
}

public class Person
{
    [JsonProperty("birthday")] public DateTime? Birthday { get; set; }

    [JsonProperty("known_for_department")] public string? KnownForDepartment { get; set; }

    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("name")] public string Name { get; set; } = string.Empty;

    [JsonProperty("also_known_as")] public string[]? AlsoKnownAs { get; set; }

    [JsonProperty("gender")] public Gender Gender { get; set; } = Gender.Unknown;

    [JsonProperty("biography")] public string? Biography { get; set; }

    [JsonProperty("popularity")] public float? Popularity { get; set; }

    [JsonProperty("place_of_birth")] public string? PlaceOfBirth { get; set; }

    [JsonProperty("profile_path")] public string? ProfilePath { get; set; }

    [JsonProperty("adult")] public bool Adult { get; set; }

    [JsonProperty("imdb_id")] public string? ImdbId { get; set; }
}