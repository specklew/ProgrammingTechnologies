using MusicShop.Service.API;

namespace MusicShop.Service.Data;

public class UserData : IUserData
{
    public int Id { get; }
    public string Name { get; set; }
    public int Age { get; set; }
    
    public UserData(int id)
    {
        Id = id;
    }
}