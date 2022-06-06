using System.Collections.Generic;

namespace Services.API;

public interface IProductService
{
    IEnumerable<IProductData> GetAllProducts();
    IProductData GetProduct(int productId);
    bool AddProduct(int productId, string name, int price);
    bool AddProduct(int productId, string name, string description, int price);
    bool UpdateProduct(int productId, string name, string description, int price);
    bool DeleteProduct(int productId);
}