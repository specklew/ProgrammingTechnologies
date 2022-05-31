using Presentation.Model.API;

namespace Presentation.Model;

public class ProductModel : IProductModel
{
    public int Id { get; }
    public string Name { get; }
    public string Description { get; set; }
    public float Price { get; set; }
    
    public ProductModel(int productId, string name, string description, float price)
    {
        Id = productId;
        Name = name;
        Description = description;
        Price = price;
    }
}