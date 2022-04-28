namespace MusicShop.Data;

public class Product
{
    public string Name { get; }
    public string Description { get; set; }
    public float Price { get; set; }

    public Product(string name, float price)
    {
        Name = name;
        Description = "This product does not have a description";
        Price = price;
    }

    public Product(string name, string description, float price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
}