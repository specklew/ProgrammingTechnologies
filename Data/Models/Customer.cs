using Data.Interfaces;

namespace Data.Models;

internal class Customer : IUser
{
    public int Id { get; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Customer(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}