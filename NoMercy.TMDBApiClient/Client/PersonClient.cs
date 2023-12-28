using NoMercy.TMDBApi.Helpers;
using NoMercy.TMDBApi.Models.People;

namespace NoMercy.TMDBApi.Client;

public class PersonClient : BaseClient
{
    public PersonClient(int id, string[]? appendices = null) : base(id)
    {
    }

    public async Task<PersonDetails> Details()
    {
        var res = await Get("person/" + Id);

        return JsonHelper.FromJson<PersonDetails>(res);
    }

    public async Task<PersonAppends> WithAppends(string[] appendices)
    {
        var @params = new Dictionary<string, string>
        {
            ["append_to_response"] = string.Join(",", appendices)
        };

        var res = await Get("person/" + Id, @params);

        return JsonHelper.FromJson<PersonAppends>(res);
    }

    public async Task<PersonAppends> WithAllAppends()
    {
        return await WithAppends(new[]
        {
            "changes",
            "details",
            "movie_credits",
            "tv_credits",
            "external_ids",
            "images",
            "translations"
        });
    }

    public async Task<PersonChanges> Changes(string startDate, string endDate)
    {
        var @params = new Dictionary<string, string>
        {
            ["start_date"] = startDate,
            ["end_date"] = endDate
        };

        var res = await Get("person/" + Id + "/changes", @params);
        return JsonHelper.FromJson<PersonChanges>(res);
    }

    public async Task<PersonMovieCredits> MovieCredits()
    {
        var res = await Get("person/" + Id + "/movie_credits");
        return JsonHelper.FromJson<PersonMovieCredits>(res);
    }

    public async Task<PersonTvCredits> TvCredits()
    {
        var res = await Get("person/" + Id + "/tv_credits");
        return JsonHelper.FromJson<PersonTvCredits>(res);
    }

    public async Task<PersonExternalIds> ExternalIds()
    {
        var res = await Get("person/" + Id + "/external_ids");
        return JsonHelper.FromJson<PersonExternalIds>(res);
    }

    public async Task<PersonImages> Images()
    {
        var res = await Get("person/" + Id + "/images");
        return JsonHelper.FromJson<PersonImages>(res);
    }

    public async Task<PersonTranslations> Translations()
    {
        var res = await Get("person/" + Id + "/translations");
        return JsonHelper.FromJson<PersonTranslations>(res);
    }
}