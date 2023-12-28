using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Shared;

public class SpokenLanguage
{
    [JsonProperty("iso_639_1")] public string Iso6391 { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}