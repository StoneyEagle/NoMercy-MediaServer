namespace NoMercy.TMDBApi.Client;

public class Client
{
    public static TvClient Tv(int? id = 0)
    {
        return new TvClient(id);
    }

    public static SeasonClient Season(int id, int seasonNumber)
    {
        return new SeasonClient(id, seasonNumber);
    }

    public static EpisodeClient Episode(int id, int seasonNumber, int episodeNumber)
    {
        return new EpisodeClient(id, seasonNumber, episodeNumber);
    }

    public static CollectionClient Collection(int id)
    {
        return new CollectionClient(id);
    }

    public static MovieClient Movie(int? id = 0)
    {
        return new MovieClient(id);
    }

    public static PersonClient Person(int id)
    {
        return new PersonClient(id);
    }
}