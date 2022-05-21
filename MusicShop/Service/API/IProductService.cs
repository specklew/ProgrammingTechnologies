namespace MusicShop.Service.API;

public interface IProductService
{
    IProductData GetProduct(int productId);
    bool AddProduct(int productId, string name, float price);
    bool AddProduct(int productId, string name, string description, float price);
    bool UpdateProduct(int productId, string name, string description, float price);
    bool DeleteProduct(int productId);
}