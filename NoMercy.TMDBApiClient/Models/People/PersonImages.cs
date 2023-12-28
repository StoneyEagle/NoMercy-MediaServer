using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.People;

public class PersonImages
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("profiles")] public Profile[] Profiles { get; set; } = Array.Empty<Profile>();
}