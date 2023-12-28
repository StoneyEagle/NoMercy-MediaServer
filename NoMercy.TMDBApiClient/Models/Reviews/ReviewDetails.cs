using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Reviews;

public class ReviewDetails
{
    [JsonProperty("id")] public string Id { get; set; } = string.Empty;

    [JsonProperty("author")] public string Author { get; set; } = string.Empty;

    [JsonProperty("author_details")] public AuthorDetails AuthorDetails { get; set; } = new();

    [JsonProperty("content")] public string Content { get; set; } = string.Empty;

    [JsonProperty("created_at")] public DateTime CreatedAt { get; set; }

    [JsonProperty("iso_639_1")] public string Iso6391 { get; set; } = string.Empty;

    [JsonProperty("media_id")] public int MediaId { get; set; }

    [JsonProperty("media_title")] public string MediaTitle { get; set; } = string.Empty;

    [JsonProperty("media_type")] public string MediaType { get; set; } = string.Empty;

    [JsonProperty("updated_at")] public DateTime? UpdatedAt { get; set; }

    [JsonProperty("url")] public Uri? Url { get; set; }
}

public class AuthorDetails
{
    [JsonProperty("name")] public string Name { get; set; } = string.Empty;

    [JsonProperty("username")] public string Username { get; set; } = string.Empty;

    [JsonProperty("avatar_path")] public string AvatarPath { get; set; } = string.Empty;

    [JsonProperty("rating")] public int Rating { get; set; }
}