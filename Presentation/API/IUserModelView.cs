namespace Presentation.API;

public interface IUserModelView
{
    int Id { get; }
    string Name { get; set; }
    int Age { get; set; }
}