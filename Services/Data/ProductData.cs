using Services.API;

namespace Services.Data;

public class ProductData : IProductData
{
    public int Id { get; }
    public string Name { get; }
    public string Description { get; set; }
    public float Price { get; set; }
    
    public ProductData(int productId, string name, string description, float price)
    {
        Id = productId;
        Name = name;
        Description = description;
        Price = price;
    }
}