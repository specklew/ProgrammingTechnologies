namespace Data.Interfaces;

public interface IProduct
{
    public int Id { get; }
    string Name { get; }
    string Description { get; set; }
    float Price { get; set; }
}