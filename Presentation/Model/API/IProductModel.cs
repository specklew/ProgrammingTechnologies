namespace Presentation.Model.API;

public interface IProductModel
{
    public int Id { get; }
    string Name { get; }
    string Description { get; set; }
    float Price { get; set; }
}