using MusicShop.Data.Interfaces;

namespace MusicShop.Data.Models;

public class Product : IProduct
{
    public int Id { get; }
    public string Name { get; }
    public string Description { get; set; }
    public float Price { get; set; }

    public Product(int productId, string name, float price)
    {
        Id = productId;
        Name = name;
        Description = "This product does not have a description!";
        Price = price;
    }

    public Product(int productId, string name, string description, float price)
    {
        Id = productId;
        Name = name;
        Description = description;
        Price = price;
    }
}