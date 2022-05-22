using Services.API;

namespace Services.Data;

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