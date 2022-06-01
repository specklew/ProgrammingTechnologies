using Presentation.Model.API;

namespace Presentation.Model;

public class ProductModelData : IProductModelData
{
    public int Id { get; }
    public string Name { get; }
    public string Description { get; set; }
    public int Price { get; set; }
    
    public ProductModelData(int productId, string name, string description, int price)
    {
        Id = productId;
        Name = name;
        Description = description;
        Price = price;
    }

}