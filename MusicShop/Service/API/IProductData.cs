namespace MusicShop.Service.API;

public interface IProductData
{
    public int Id { get; }
    string Name { get; }
    string Description { get; set; }
    float Price { get; set; }
}