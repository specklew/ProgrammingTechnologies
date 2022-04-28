namespace MusicShop.Data;

public interface IState
{
    ProductCatalog Catalog { get; }
    int Id { get; set; }

    int GetProductQuantity(Product product);
    Dictionary<Product, int> GetProductsQuantity();
    void SetProductQuantity(Product product, int count);
    void SetProductsQuantity(Dictionary<Product, int> valuePairs);
}