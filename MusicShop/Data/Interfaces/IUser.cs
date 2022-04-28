namespace MusicShop.Data;

public interface IUser
{
    string Guid { get; }
    string Name { get; set; }
    int Age { get; set; }
}