using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NoMercy.Server.Logic;
using NoMercy.Server.Models;

namespace NoMercy.Server.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize()]
public class UsersController(UserLogic profileAdmin) : Controller
{
    [HttpGet]
    public List<User> GetProfiles()
    {
        string? session = this.HttpContext.Items.FirstOrDefault(x => ReferenceEquals(x.Key, "UserId")).Value?.ToString();
        return profileAdmin.GetUsers();
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetProfile(Guid id)
    {
        var profile = profileAdmin.GetUser(id);
        if (profile == null)
            return NotFound();
        return Ok(profile);
    }

    [HttpPost]
    public IActionResult CreateProfile(User profile)
    {
        var updatedProfile = profileAdmin.AddUser(profile);
        return Ok(updatedProfile);
    }

    [HttpPut]
    public IActionResult UpdateProfile(User profile)
    {
        var updatedProfile = profileAdmin.UpdateUser(profile);
        if (updatedProfile == null)
            return NotFound();
        return Ok(updatedProfile);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteProfile(Guid id)
    {
        profileAdmin.DeleteUser(id);
        return Ok();
    }
}