using MusicShop.Data;
using MusicShop.Data.Interfaces;
using MusicShop.Service.API;

namespace MusicShop.Service.Data;

public class ProductService : IProductService
{
    private readonly DataRepository _dataRepository;

    public ProductService(DataRepository dataRepository)
    {
        _dataRepository = dataRepository;
    }

    private static IProductData Transform(IProduct product)
    {
        return product == null ? null : new ProductData(product.Id, product.Name);
    }

    public IProductData GetProduct(int productId)
    {
        return Transform(_dataRepository.GetProduct(productId));
    }

    public bool AddProduct(int productId, string name, float price)
    {
        return _dataRepository.AddProduct(productId, name, price);
    }

    public bool AddProduct(int productId, string name, string description, float price)
    {
        return _dataRepository.AddProduct(productId, name, description, price);
    }

    public bool UpdateProduct(int productId, string name, string description, float price)
    {
        return _dataRepository.UpdateProduct(productId, name, description, price);
    }

    public bool DeleteProduct(int productId)
    {
        return _dataRepository.DeleteProduct(productId);
    }
}