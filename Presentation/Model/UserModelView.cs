using Presentation.API;

namespace Presentation.Model;

public class UserModelView : IUserModelView
{
    public int Id { get; }
    public string Name { get; set; }
    public int Age { get; set; }

    public UserModelView(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}