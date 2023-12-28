using Newtonsoft.Json;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Models.People;

public class PersonTaggedImages : PaginatedResponse<TaggedImage>
{
    [JsonProperty("id")] public string Id { get; set; }
}

public class TaggedImage : Profile
{
    [JsonProperty("id")] public string Id { get; set; } = string.Empty;

    [JsonProperty("image_type")] public string ImageType { get; set; } = string.Empty;

    [JsonProperty("media")] public Media<Person> Media { get; set; } = new();

    [JsonProperty("media_type")] public string MediaType { get; set; } = string.Empty;
}

public class Media<T> where T : class
{
    [JsonProperty("_id")] public string Id { get; set; } = string.Empty;

    [JsonProperty("id")] public int MediaId { get; set; }

    [JsonProperty("release_date")] public DateTime? ReleaseDate { get; set; }
}