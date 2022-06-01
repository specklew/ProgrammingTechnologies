using System.Collections.Generic;
using Presentation.Model.API;
using Services.API;
using Services.Data;

namespace Presentation.Model;

public class ProductModel : IProductModel
{
    internal ProductModel(IProductService service = null)
    {
        Service = service ?? new ProductService();
    }

    public IProductService Service { get; }

    public IEnumerable<IProductModelData> Products
    {
        get
        {
            List<IProductModelData> products = new();
            foreach (var data in Service.GetAllProducts())
            {
                products.Add(new ProductModelData(data.Id, data.Name, data.Description, data.Price));
            }
            return products;
        }
    }

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