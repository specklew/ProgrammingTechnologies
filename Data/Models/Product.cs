using Data.Interfaces;

namespace Data.Models;

public class Product : IProduct
{
    public int Id { get; }
    public string Name { get; }
    public string Description { get; set; }
    public float Price { get; set; }

    public Product(int productId, string name, string description, float price)
    {
        Id = productId;
        Name = name;
        Description = description;
        Price = price;
    }
}