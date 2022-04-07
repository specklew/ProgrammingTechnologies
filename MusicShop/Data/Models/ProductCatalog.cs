﻿using System.Collections.ObjectModel;

namespace MusicShop.Data
{
    internal class ProductCatalog : Collection<Product>
    {
        public new void Add(Product product)
        {
            foreach(Product item in Items)
            {
                if (item == product) return;
            }
            Items.Add(product);
        }
    }
}
