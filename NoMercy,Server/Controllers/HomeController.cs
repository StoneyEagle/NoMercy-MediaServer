using Microsoft.AspNetCore.Mvc;

namespace NoMercy.Server.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    [Route("/")]
    public IActionResult Index()
    {
        return Ok();
    }
    
    [HttpGet]
    [Route("/status")]
    public IActionResult Status()
    {
        return Ok();
    }
    
}