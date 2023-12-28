namespace NoMercy.Server.Models;

public class Tv
{
    public int Id { get; set; }
    public string Title { set; get; } = "";
    public string TitleSort { set; get; } = "";
    public int HaveEpisodes { set; get; }
    public string? Folder { set; get; }
    public string? Backdrop { set; get; }
    public DateTime CreatedAt { set; get; } = DateTime.Now;
    public int Duration { set; get; }
    public string? FirstAirDate { set; get; }
    public string? Homepage { set; get; }
    public string? ImdbId { set; get; }
    public bool? InProduction { set; get; }
    public int? LastEpisodeToAir { set; get; }
    public DateTime? LastAirDate { set; get; }
    public string? MediaType { set; get; }
    public int? NextEpisodeToAir { set; get; }
    public int? NumberOfEpisodes { set; get; }
    public int? NumberOfSeasons { set; get; }
    public string? OriginCountry { set; get; }
    public string? OriginalLanguage { set; get; }
    public string? Overview { set; get; }
    public int? Popularity { set; get; }
    public string? Poster { set; get; }
    public string? SpokenLanguages { set; get; }
    public string? Status { set; get; }
    public string? Tagline { set; get; }
    public string? Trailer { set; get; }
    public int? TvdbId { set; get; }
    public string? Type { set; get; }
    public DateTime UpdatedAt { set; get; } = DateTime.Now;
    public float? VoteAverage { set; get; }
    public int? VoteCount { set; get; }
    public string? ColorPalette { set; get; }
}