using Presentation.Model.API;

namespace Presentation.Model;

internal class UserModelData : IUserModelData
{
    public int Id { get; }
    public string Name { get; set; }
    public int Age { get; set; }

    internal UserModelData(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}