namespace Services.API;

public interface IUserData
{
    int Id { get; }
    string Name { get; set; }
    int Age { get; set; }
}