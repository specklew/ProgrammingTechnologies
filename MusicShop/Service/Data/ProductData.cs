using MusicShop.Service.API;

namespace MusicShop.Service.Data;

public class ProductData : IProductData
{
    public int Id { get; }
    public string Name { get; }
    public string Description { get; set; }
    public float Price { get; set; }
    
    public ProductData(int id, string name)
    {
        Id = id;
        Name = name;
    }
}