using NoMercy.TMDBApi.Helpers;
using NoMercy.TMDBApi.Models.Episode;
using NoMercy.TMDBApi.Models.Shared;

namespace NoMercy.TMDBApi.Client;

public class EpisodeClient : BaseClient
{
    public int EpisodeNumber;
    public int SeasonNumber;

    public EpisodeClient(int id, int seasonNumber, int episodeNumber, string[]? appendices = null) : base(id)
    {
        SeasonNumber = seasonNumber;
        EpisodeNumber = episodeNumber;
    }

    public async Task<EpisodeDetails> Details()
    {
        var res = await Get("tv/" + Id + "/season/" + SeasonNumber + "/episode/" + EpisodeNumber);
        return JsonHelper.FromJson<EpisodeDetails>(res);
    }

    public async Task<EpisodeAppends> WithAppends(string[] appendices)
    {
        var @params = new Dictionary<string, string>
        {
            ["append_to_response"] = string.Join(",", appendices)
        };

        var res = await Get("tv/" + Id + "/season/" + SeasonNumber + "/episode/" + EpisodeNumber, @params);

        return JsonHelper.FromJson<EpisodeAppends>(res);
    }

    public async Task<EpisodeAppends> WithAllAppends()
    {
        return await WithAppends(new[]
        {
            "changes",
            "credits",
            "external_ids",
            "images",
            "translations",
            "videos"
        });
    }

    public async Task<EpisodeChanges> Changes(string startDate, string endDate)
    {
        var @params = new Dictionary<string, string>
        {
            ["start_date"] = startDate,
            ["end_date"] = endDate
        };

        var res = await Get("tv/" + Id + "/season/" + SeasonNumber + "/episode/" + EpisodeNumber + "/changes", @params);
        return JsonHelper.FromJson<EpisodeChanges>(res);
    }

    public async Task<Credits> Credits()
    {
        var res = await Get("tv/" + Id + "/season/" + SeasonNumber + "/episode/" + EpisodeNumber + "/credits");
        return JsonHelper.FromJson<Credits>(res);
    }

    public async Task<ExternalIds> ExternalIds()
    {
        var res = await Get("tv/" + Id + "/season/" + SeasonNumber + "/episode/" + EpisodeNumber + "/external_ids");
        return JsonHelper.FromJson<ExternalIds>(res);
    }

    public async Task<Images> Images()
    {
        var res = await Get("tv/" + Id + "/season/" + SeasonNumber + "/episode/" + EpisodeNumber + "/images");
        return JsonHelper.FromJson<Images>(res);
    }

    public async Task<SharedTranslations> Translations()
    {
        var res = await Get("tv/" + Id + "/season/" + SeasonNumber + "/episode/" + EpisodeNumber + "/translations");
        return JsonHelper.FromJson<SharedTranslations>(res);
    }

    public async Task<Videos> Videos()
    {
        var res = await Get("tv/" + Id + "/season/" + SeasonNumber + "/episode/" + EpisodeNumber + "/videos");
        return JsonHelper.FromJson<Videos>(res);
    }
}