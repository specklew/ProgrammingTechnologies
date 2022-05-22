namespace Data.Interfaces;

public interface IUser
{
    int Id { get; }
    string Name { get; set; }
    int Age { get; set; }
}