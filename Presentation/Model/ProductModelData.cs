using System.Collections.Generic;
using Presentation.Model.API;
using Services.API;

namespace Presentation.Model;

public class ProductModelData : IProductModelData
{
    public ProductModelData(IProductService service)
    {
        Service = service;
    }
    public IProductService Service { get; }
    public IEnumerable<IProductData> Product => Service.GetAllProducts();
    
    public IProductModel CreateProduct(int productId, string name, string description, float price)
    {
        return new ProductModel(productId, name, description, price);
    }
}