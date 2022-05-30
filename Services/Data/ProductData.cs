using Services.API;

namespace Services.Data;

public class ProductData : IProductData
{
    public int Id { get; }
    public string Name { get; }
    public string Description { get; set; }
    public int Price { get; set; }
    
    public ProductData(int productId, string name, string description, int price)
    {
        Id = productId;
        Name = name;
        Description = description;
        Price = price;
    }
}