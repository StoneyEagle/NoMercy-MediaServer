using NoMercy.TMDBApi.Helpers;
using NoMercy.TMDBApi.Models.Movies;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Client;

public class MovieClient : BaseClient
{
    public MovieClient(int? id = 0, string[]? appendices = null) : base((int)id)
    {
    }

    public async Task<MovieDetails> Details()
    {
        var res = await Get("movie/" + Id);
        return JsonHelper.FromJson<MovieDetails>(res);
    }

    public async Task<MovieAppends> WithAppends(string[] appendices)
    {
        var @params = new Dictionary<string, string>
        {
            ["append_to_response"] = string.Join(",", appendices)
        };

        var res = await Get("movie/" + Id, @params);

        return JsonHelper.FromJson<MovieAppends>(res);
    }

    public async Task<MovieAppends> WithAllAppends()
    {
        return await WithAppends(new[]
        {
            "alternative_titles",
            "release_dates",
            "changes",
            "credits",
            "keywords",
            "recommendations",
            "similar",
            "translations",
            "external_ids",
            "videos",
            "images",
            "watch/providers"
        });
    }

    public async Task<MovieAggregatedCredits> AggregatedCredits()
    {
        var res = await Get("movie/" + Id + "/aggregate_credits");
        return JsonHelper.FromJson<MovieAggregatedCredits>(res);
    }

    public async Task<MovieAlternativeTitles> AlternativeTitles()
    {
        var res = await Get("movie/" + Id + "/alternative_titles");
        return JsonHelper.FromJson<MovieAlternativeTitles>(res);
    }

    public async Task<MovieChanges> Changes(string startDate, string endDate)
    {
        var @params = new Dictionary<string, string>
        {
            ["start_date"] = startDate,
            ["end_date"] = endDate
        };

        var res = await Get("movie/" + Id + "/changes", @params);
        return JsonHelper.FromJson<MovieChanges>(res);
    }

    public async Task<MovieCredits> Credits()
    {
        var res = await Get("movie/" + Id + "/credits");
        return JsonHelper.FromJson<MovieCredits>(res);
    }

    public async Task<MovieExternalIds> ExternalIds()
    {
        var res = await Get("movie/" + Id + "/external_ids");
        return JsonHelper.FromJson<MovieExternalIds>(res);
    }

    public async Task<MovieImages> Images()
    {
        var res = await Get("movie/" + Id + "/images");
        return JsonHelper.FromJson<MovieImages>(res);
    }

    public async Task<MovieKeywords> Keywords()
    {
        var res = await Get("movie/" + Id + "/keywords");
        return JsonHelper.FromJson<MovieKeywords>(res);
    }

    public async Task<MovieLists> Lists()
    {
        var res = await Get("movie/" + Id + "/lists");
        return JsonHelper.FromJson<MovieLists>(res);
    }

    public async Task<MovieRecommendations> Recommendations()
    {
        var res = await Get("movie/" + Id + "/recommendations");
        return JsonHelper.FromJson<MovieRecommendations>(res);
    }

    public async Task<MovieReleaseDates> ReleaseDates()
    {
        var res = await Get("movie/" + Id + "/release_dates");
        return JsonHelper.FromJson<MovieReleaseDates>(res);
    }

    public async Task<MovieReviews> Reviews()
    {
        var res = await Get("movie/" + Id + "/reviews");
        return JsonHelper.FromJson<MovieReviews>(res);
    }

    public async Task<MovieSimilar> Similar()
    {
        var res = await Get("movie/" + Id + "/similar");
        return JsonHelper.FromJson<MovieSimilar>(res);
    }

    public async Task<SharedTranslations> Translations()
    {
        var res = await Get("movie/" + Id + "/translations");
        return JsonHelper.FromJson<SharedTranslations>(res);
    }

    public async Task<MovieVideos> Videos()
    {
        var res = await Get("movie/" + Id + "/videos");
        return JsonHelper.FromJson<MovieVideos>(res);
    }

    public async Task<MovieWatchProviders> WatchProviders()
    {
        var res = await Get("movie/" + Id + "/watch/providers");
        return JsonHelper.FromJson<MovieWatchProviders>(res);
    }

    public async Task<MovieLatest> Latest()
    {
        var res = await Get("movie/" + Id + "/latest");
        return JsonHelper.FromJson<MovieLatest>(res);
    }

    public async Task<MovieNowPlaying> NowPlaying()
    {
        var res = await Get("movie/" + Id + "/now_playing");
        return JsonHelper.FromJson<MovieNowPlaying>(res);
    }

    public async Task<MoviePopular> Popular()
    {
        var res = await Get("movie/" + Id + "/popular");
        return JsonHelper.FromJson<MoviePopular>(res);
    }

    public async Task<MovieTopRated> TopRated()
    {
        var res = await Get("movie/" + Id + "/top_rated");
        return JsonHelper.FromJson<MovieTopRated>(res);
    }

    public async Task<MovieUpcoming> Upcoming()
    {
        var res = await Get("movie/" + Id + "/upcoming");
        return JsonHelper.FromJson<MovieUpcoming>(res);
    }

    public async Task<Certification> Certifications()
    {
        var res = await Get("certification/movie/list");
        return JsonHelper.FromJson<Certification>(res);
    }
}