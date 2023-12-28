using NoMercy.TMDBApi.Models.Movies;
using NoMercy.TMDBApi.Models.People;
using NoMercy.TMDBApi.Models.Shared;
using NoMercy.TMDBApi.Models.TV;

namespace NoMercy.TMDBApi.Models.Search;

public class Multi : PaginatedResponse<(Movie, TvShow, Person)>
{
}