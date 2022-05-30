using System.Collections.Generic;

namespace Services.API;

public interface IProductService
{
    IEnumerable<IProductData> GetAllProducts();
    IProductData GetProduct(int productId);
    bool AddProduct(int productId, string name, float price);
    bool AddProduct(int productId, string name, string description, float price);
    bool UpdateProduct(int productId, string name, string description, float price);
    bool DeleteProduct(int productId);
    void NukeData();
}