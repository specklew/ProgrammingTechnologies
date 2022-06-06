using System.Collections.Generic;
using Data;
using Data.Interfaces;
using Services.API;

namespace Services.Data;

public class ProductService : IProductService
{
    private readonly IDataLayerApi _dataRepository;
    
    public ProductService(IDataLayerApi dataRepository = default)
    {
        _dataRepository = dataRepository ?? new DataRepository();
    }

    private static IProductData Transform(IProduct product)
    {
        return product == null ? null : new ProductData(product.Id, product.Name, product.Description, product.Price);
    }

    public IEnumerable<IProductData> GetAllProducts()
    {
        List<IProductData> products = new List<IProductData>();
        foreach (IProduct product in _dataRepository.GetAllProducts())
        {
            products.Add(Transform(product));
        }

        return products;
    }

    public IProductData GetProduct(int productId)
    {
        return Transform(_dataRepository.GetProduct(productId));
    }

    public bool AddProduct(int productId, string name, int price)
    {
        return _dataRepository.AddProduct(productId, name, price);
    }

    public bool AddProduct(int productId, string name, string description, int price)
    {
        return _dataRepository.AddProduct(productId, name, description, price);
    }

    public bool UpdateProduct(int productId, string name, string description, int price)
    {
        return _dataRepository.UpdateProduct(productId, name, description, price);
    }

    public bool DeleteProduct(int productId)
    {
        return _dataRepository.DeleteProduct(productId);
    }
}