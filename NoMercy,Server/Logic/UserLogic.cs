using NoMercy.Server.Models;

namespace NoMercy.Server.Logic;

public class UserLogic
{
    private List<User> Users { get; } = new()
    {
        new User
        {
            Id = new Guid("3221ec74-cbed-4280-93e6-258c0edcd1f4"),
            Name = "iFill It",
            Email = "mistaaa@nomercy.tv",
            Owner = false,
            Manage = true,
            Allowed = true
        },
        new User
        {
            Id = new Guid("6aa35c70-7136-44f3-baba-e1d464433426"),
            Name = "Stoney_Eagle",
            Email = "stoney@nomercy.tv",
            Owner = true,
            Manage = true,
            Allowed = true
        }
    };

    public List<User> GetUsers()
    {
        return Users;
    }

    public User? GetUser(Guid id)
    {
        return Users.FirstOrDefault(p => p.Id == id);
    }

    public User? GetUser(string email)
    {
        return Users.FirstOrDefault(p => p.Email == email);
    }

    public User AddUser(User user)
    {
        user.Id = new Guid();
        Users.Add(user);

        return user;
    }

    public User? UpdateUser(User user)
    {
        var userProfile = GetUser(user.Id);
        if (userProfile == null) return null;

        userProfile.Name = user.Name;
        userProfile.Email = user.Email;
        userProfile.Allowed = user.Allowed;

        return userProfile;
    }

    public void DeleteUser(Guid id)
    {
        Users.RemoveAll(p => p.Id == id);
    }
}