namespace Data.Interfaces;

public interface IProduct
{
    public int Id { get; }
    string Name { get; set; }
    string Description { get; set; }
    int Price { get; set; }
}