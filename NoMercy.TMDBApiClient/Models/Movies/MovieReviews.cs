using Newtonsoft.Json;

namespace NoMercy.TMDBApi.Models.Movies;

public class MovieReviews
{
    [JsonProperty("id")] public int Id { get; set; }

    [JsonProperty("page")] public int Page { get; set; }

    [JsonProperty("results")] public ReviewsResult[] Results { get; set; } = { };

    [JsonProperty("total_pages")] public int TotalPages { get; set; }

    [JsonProperty("total_results")] public int TotalResults { get; set; }
}

public class ReviewsResult
{
    [JsonProperty("author")] public string Author { get; set; } = string.Empty;

    [JsonProperty("author_details")] public AuthorDetails AuthorDetails { get; set; } = new();

    [JsonProperty("content")] public string Content { get; set; } = string.Empty;

    [JsonProperty("created_at")] public DateTime CreatedAt { get; set; }

    [JsonProperty("id")] public string Id { get; set; } = string.Empty;

    [JsonProperty("updated_at")] public DateTime UpdatedAt { get; set; }

    [JsonProperty("url")] public Uri? Url { get; set; }
}

public class AuthorDetails
{
    [JsonProperty("name")] public string Name { get; set; } = string.Empty;

    [JsonProperty("username")] public string Username { get; set; } = string.Empty;

    [JsonProperty("avatar_path")] public string AvatarPath { get; set; } = string.Empty;

    [JsonProperty("rating")] public int? Rating { get; set; }
}