using NoMercy.TMDBApi.Helpers;
using NoMercy.TMDBApi.Models.Collections;

namespace NoMercy.TMDBApi.Client;

public class CollectionClient : BaseClient
{
    public CollectionClient(int id, string[]? appendices = null) : base(id)
    {
    }

    public async Task<CollectionDetails> Details()
    {
        var res = await Get("collection/" + Id);
        return JsonHelper.FromJson<CollectionDetails>(res);
    }

    public async Task<CollectionAppends> WithAppends(string[] appendices)
    {
        var @params = new Dictionary<string, string>
        {
            ["append_to_response"] = string.Join(",", appendices)
        };

        var res = await Get("collection/" + Id, @params);

        return JsonHelper.FromJson<CollectionAppends>(res);
    }

    public async Task<CollectionAppends> WithAllAppends()
    {
        return await WithAppends(new[]
        {
            "images",
            "translations"
        });
    }

    public async Task<CollectionImages> Images()
    {
        var res = await Get("collection/" + Id + "/images");
        return JsonHelper.FromJson<CollectionImages>(res);
    }

    public async Task<CollectionsTranslations> Translations()
    {
        var res = await Get("collection/" + Id + "/translations");
        return JsonHelper.FromJson<CollectionsTranslations>(res);
    }
}