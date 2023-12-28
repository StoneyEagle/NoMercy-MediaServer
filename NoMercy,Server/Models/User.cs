namespace NoMercy.Server.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public bool Owner { get; set; }
    public bool Manage { get; set; }
    public bool Allowed { get; set; } = true;
}