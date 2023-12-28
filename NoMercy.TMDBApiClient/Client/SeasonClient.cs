using NoMercy.TMDBApi.Helpers;
using NoMercy.TMDBApi.Models.Season;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Client;

public class SeasonClient : BaseClient
{
    private readonly int _seasonNumber;

    public SeasonClient(int tvId, int seasonNumber, string[]? appendices = null) : base(tvId)
    {
        _seasonNumber = seasonNumber;
    }

    public EpisodeClient Episode(int episodeNumber, string[]? items = null)
    {
        return new EpisodeClient(Id, _seasonNumber, episodeNumber);
    }

    public async Task<SeasonDetails> Details()
    {
        var res = await Get("tv/" + Id + "/season/" + _seasonNumber);
        return JsonHelper.FromJson<SeasonDetails>(res);
    }

    public async Task<SeasonAppends> WithAppends(string[] appendices)
    {
        var @params = new Dictionary<string, string>
        {
            ["append_to_response"] = string.Join(",", appendices)
        };

        var res = await Get("tv/" + Id + "/season/" + _seasonNumber, @params);

        return JsonHelper.FromJson<SeasonAppends>(res);
    }

    public async Task<SeasonAppends> WithAllAppends()
    {
        return await WithAppends(new[]
        {
            "aggregate_credits",
            "changes",
            "credits",
            "external_ids",
            "images",
            "translations"
        });
    }

    //public async Task<AccountStates> AccountStates()
    //{
    //    string res = await Get("tv/" + Id + "/season/" + SeasonNumber + "/account_states");
    //    return JsonHelper.FromJson<Details>(res);
    //}

    public async Task<SeasonAggregatedCredits> AggregatedCredits()
    {
        var res = await Get("tv/" + Id + "/season/" + _seasonNumber + "/aggregate_credits");
        return JsonHelper.FromJson<SeasonAggregatedCredits>(res);
    }

    public async Task<SeasonChanges> Changes(string startDate, string endDate)
    {
        var @params = new Dictionary<string, string>
        {
            ["start_date"] = startDate,
            ["end_date"] = endDate
        };

        var res = await Get("tv/" + Id + "/season/" + _seasonNumber + "/changes", @params);
        return JsonHelper.FromJson<SeasonChanges>(res);
    }

    public async Task<Credits> Credits()
    {
        var res = await Get("tv/" + Id + "/season/" + _seasonNumber + "/credits");
        return JsonHelper.FromJson<Credits>(res);
    }

    public async Task<ExternalIds> ExternalIds()
    {
        var res = await Get("tv/" + Id + "/season/" + _seasonNumber + "/external_ids");
        return JsonHelper.FromJson<ExternalIds>(res);
    }

    public async Task<Images> Images()
    {
        var res = await Get("tv/" + Id + "/season/" + _seasonNumber + "/images");
        return JsonHelper.FromJson<Images>(res);
    }

    public async Task<SharedTranslations> Translations()
    {
        var res = await Get("tv/" + Id + "/season/" + _seasonNumber + "/translations");
        return JsonHelper.FromJson<SharedTranslations>(res);
    }

    public async Task<Videos> Videos()
    {
        var res = await Get("tv/" + Id + "/season/" + _seasonNumber + "/videos");
        return JsonHelper.FromJson<Videos>(res);
    }
}