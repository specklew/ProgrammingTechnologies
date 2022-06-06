using System.Collections.Generic;
using Data.Models;
using Presentation.Model;
using Presentation.Model.API;
using Services.API;
using Services.Data;

namespace MusicShopTests.Presentation.Dummies;

internal class ProductModelDummy : IProductModel
{
    internal ProductModelDummy(IProductService service = null)
    {
        Service = service ?? new ProductService();
        Products = new List<IProductModelData>();
    }

    public IProductService Service { get; }

    public IEnumerable<IProductModelData> Products { get; }

    public bool Add(int id, string name, string description, int age)
    {
        return Service.AddProduct(id, name, description, age);
    }
    
    public bool Delete(int id)
    {
        return Service.DeleteProduct(id);
    }
    
    public bool Update(int id, string name, string description, int price)
    {
        return Service.UpdateProduct(id, name, description, price);
    }
}