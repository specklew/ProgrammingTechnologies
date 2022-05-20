using System.Collections.ObjectModel;
using System.Linq;

namespace MusicShop.Data;

public class ProductCatalog : Collection<Product>
{
    public new void Add(Product product)
    {
        if (Items.Any(item => item == product))
        {
            return;
        }

        Items.Add(product);
    }
}