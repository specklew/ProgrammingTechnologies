namespace Presentation.Model.API;

public interface IProductModelData
{
    public int Id { get; }
    string Name { get; }
    string Description { get; set; }
    int Price { get; set; }
}