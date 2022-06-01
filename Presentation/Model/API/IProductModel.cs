using System.Collections.Generic;
using Services.API;

namespace Presentation.Model.API;

public interface IProductModel
{
    public IProductService Service { get; }
    IEnumerable<IProductModelData> Products { get; }
    public bool Add(int id, string name, string description, int age);
    public bool Delete(int id);
    public bool Update(int id, string name, string description, int price);
}