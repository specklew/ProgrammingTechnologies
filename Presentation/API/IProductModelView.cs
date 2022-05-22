namespace Presentation.API;

public interface IProductModelView
{
    public int Id { get; }
    string Name { get; }
    string Description { get; set; }
    float Price { get; set; }
}