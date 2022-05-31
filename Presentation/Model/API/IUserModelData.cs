namespace Presentation.Model.API;

public interface IUserModelData
{
    int Id { get; }
    string Name { get; set; }
    int Age { get; set; }
}