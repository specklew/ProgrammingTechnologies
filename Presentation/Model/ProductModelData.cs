using System.Collections.Generic;
using Presentation.API;
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
    
    public IProductModelView CreateProduct(int productId, string name, string description, float price)
    {
        return new ProductModelView(productId, name, description, price);
    }
}