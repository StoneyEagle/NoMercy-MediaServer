using Microsoft.AspNetCore.Mvc;
using NoMercy.TMDBApi.Client;
using NoMercy.TMDBApi.Models.TV;

namespace NoMercy.Server.Controllers;

[Route("[controller]")]
[ApiController]
public class TvController : Controller
{
    [HttpGet]
    public async Task<TvPopulair> Index()
    {
        TvClient tvClient = new TvClient();
        return await tvClient.Popular();
    }

    [HttpGet("{id:int}")]
    public async Task<TvShowAppends> Get(int id)
    {
        TvClient tvClient = new TvClient(id);
        var tv = await tvClient.WithAllAppends();
        return tv;
    }

    [HttpPost("{id:int}")]
    public async Task<TvShowAppends> Create(int id)
    {
        TvClient tvClient = new (id);
        var tv = await tvClient.WithAllAppends();
        return tv;
    }

    [HttpDelete("{id:int}")]
    public async Task<TvShowAppends> DeleteTv(int id)
    {
        TvClient tvClient = new (id);
        var tv = await tvClient.WithAllAppends();
        return tv;
    }
}