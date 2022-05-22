using System.Collections.Generic;
using Services.API;

namespace Presentation.API;

public interface IProductModelData
{
    public IProductService Service { get; }
    IEnumerable<IProductData> Product { get; }
    IProductModelView CreateProduct(int productId, string name, string description, float price);
}