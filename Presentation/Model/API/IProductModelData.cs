using System.Collections.Generic;
using Services.API;

namespace Presentation.Model.API;

public interface IProductModelData
{
    public IProductService Service { get; }
    IEnumerable<IProductData> Product { get; }
    IProductModel CreateProduct(int productId, string name, string description, float price);
}