using Presentation.API;

namespace Presentation.Model;

public class ProductModelView : IProductModelView
{
    public int Id { get; }
    public string Name { get; }
    public string Description { get; set; }
    public float Price { get; set; }
    
    public ProductModelView(int productId, string name, string description, float price)
    {
        Id = productId;
        Name = name;
        Description = description;
        Price = price;
    }
}