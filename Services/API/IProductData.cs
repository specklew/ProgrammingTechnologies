namespace Services.API;

public interface IProductData
{
    public int Id { get; }
    string Name { get; }
    string Description { get; set; }
    int Price { get; set; }
}