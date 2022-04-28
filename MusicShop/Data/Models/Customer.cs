namespace MusicShop.Data;

internal class Customer : IUser
{
    public string Guid { get; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Customer(string name, int age)
    {
        Guid = System.Guid.NewGuid().ToString();
        Name = name;
        Age = age;
    }
}