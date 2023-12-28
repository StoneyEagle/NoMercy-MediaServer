using NoMercy.TMDBApi.Helpers;
using NoMercy.TMDBApi.Models.Shared;
using NoMercy.TMDBApi.Models.TV;

namespace NoMercy.TMDBApi.Client;

public class TvClient : BaseClient
{
    public TvClient(int? id = 0, string[]? appendices = null) : base((int)id!)
    {
    }

    public SeasonClient Season(int seasonNumber, string[]? items = null)
    {
        return new SeasonClient(Id, seasonNumber, items);
    }

    //public async Task<Models.Season.SeasonAppends> SeasonWithAppends(int SeasonNumber, string[] Appendices)
    //{
    //	return await (new SeasonClient(Id, SeasonNumber)).WithAppends(Appendices);
    //}

    public async Task<TvShowDetails> Details()
    {
        var res = await Get("tv/" + Id);

        return JsonHelper.FromJson<TvShowDetails>(res);
    }

    public async Task<TvShowAppends> WithAppends(string[] appendices)
    {
        var @params = new Dictionary<string, string>
        {
            ["append_to_response"] = string.Join(",", appendices)
        };

        var res = await Get("tv/" + Id, @params);
        return JsonHelper.FromJson<TvShowAppends>(res);

    }

    public async Task<TvShowAppends> WithAllAppends()
    {
        return await WithAppends(new[]
        {
            "aggregate_credits",
            "alternative_titles",
            "changes",
            "content_ratings",
            "credits",
            "external_ids",
            "images",
            "keywords",
            "recommendations",
            "similar",
            "translations",
            "videos",
            "watch/providers"
        });
    }

    public async Task<TvAggregatedCredits> AggregatedCredits()
    {
        var res = await Get("tv/" + Id + "/aggregate_credits");
        return JsonHelper.FromJson<TvAggregatedCredits>(res);
    }

    public async Task<TvAlternativeTitles> AlternativeTitles()
    {
        var res = await Get("tv/" + Id + "/alternative_titles");
        return JsonHelper.FromJson<TvAlternativeTitles>(res);
    }

    public async Task<TvChanges> Changes(string startDate, string endDate)
    {
        var @params = new Dictionary<string, string>
        {
            ["start_date"] = startDate,
            ["end_date"] = endDate
        };

        var res = await Get("tv/" + Id + "/changes", @params);
        return JsonHelper.FromJson<TvChanges>(res);
    }

    public async Task<TvContentRatings> ContentRatings()
    {
        var res = await Get("tv/" + Id + "/content_ratings");
        return JsonHelper.FromJson<TvContentRatings>(res);
    }

    public async Task<TvCredits> Credits()
    {
        var res = await Get("tv/" + Id + "/credits");
        return JsonHelper.FromJson<TvCredits>(res);
    }

    public async Task<TvEpisodeGroups> EpisodeGroups()
    {
        var res = await Get("tv/" + Id + "/episode_groups");
        return JsonHelper.FromJson<TvEpisodeGroups>(res);
    }

    public async Task<TvExternalIds> ExternalIds()
    {
        var res = await Get("tv/" + Id + "/external_ids");
        return JsonHelper.FromJson<TvExternalIds>(res);
    }

    public async Task<TvImages> Images()
    {
        var res = await Get("tv/" + Id + "/images");
        return JsonHelper.FromJson<TvImages>(res);
    }

    public async Task<TvKeywords> Keywords()
    {
        var res = await Get("tv/" + Id + "/keywords");
        return JsonHelper.FromJson<TvKeywords>(res);
    }

    public async Task<TvRecommendations> Recommendations()
    {
        var res = await Get("tv/" + Id + "/recommendations");
        return JsonHelper.FromJson<TvRecommendations>(res);
    }

    public async Task<TvReviews> Reviews()
    {
        var res = await Get("tv/" + Id + "/reviews");
        return JsonHelper.FromJson<TvReviews>(res);
    }

    public async Task<TvScreenedTheatrically> ScreenedTheatrically()
    {
        var res = await Get("tv/" + Id + "/screened_theatrically");
        return JsonHelper.FromJson<TvScreenedTheatrically>(res);
    }

    public async Task<TvSimilar> Similar()
    {
        var res = await Get("tv/" + Id + "/similar");
        return JsonHelper.FromJson<TvSimilar>(res);
    }

    public async Task<SharedTranslations> Translations()
    {
        var res = await Get("tv/" + Id + "/translations");
        return JsonHelper.FromJson<SharedTranslations>(res);
    }

    public async Task<TvVideos> Videos()
    {
        var res = await Get("tv/" + Id + "/videos");
        return JsonHelper.FromJson<TvVideos>(res);
    }

    public async Task<WatchProviders> WatchProviders()
    {
        var res = await Get("tv/" + Id + "/watch/providers");
        return JsonHelper.FromJson<WatchProviders>(res);
    }

    public async Task<TvShowLatest> Latest()
    {
        var res = await Get("tv/latest");
        return JsonHelper.FromJson<TvShowLatest>(res);
    }

    public async Task<TvAiringToday> AiringToday()
    {
        var res = await Get("tv/" + Id + "/airing_today");
        return JsonHelper.FromJson<TvAiringToday>(res);
    }

    public async Task<TvOnTheAir> OnTheAir()
    {
        var res = await Get("tv/on_the_air");
        return JsonHelper.FromJson<TvOnTheAir>(res);
    }

    public async Task<TvPopulair> Popular()
    {
        var res = await Get("tv/popular");
        return JsonHelper.FromJson<TvPopulair>(res);
    }

    public async Task<TvTopRated> TopRated()
    {
        var res = await Get("tv/top_rated");
        return JsonHelper.FromJson<TvTopRated>(res);
    }

    public async Task<Certification> Certifications()
    {
        var res = await Get("certification/tv/list");
        return JsonHelper.FromJson<Certification>(res);
    }
}