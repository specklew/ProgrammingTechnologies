using Data.Interfaces;

namespace Data.Models;

public class Product : IProduct
{
    public int Id { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }

    public Product(int productId, string name, string description, int price)
    {
        Id = productId;
        Name = name;
        Description = description;
        Price = price;
    }
}