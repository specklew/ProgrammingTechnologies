using System.Collections.ObjectModel;

namespace MusicShop.Data
{
    public class ProductCatalog : Collection<ProductLine>
    {
        public void Add(Product product)
        {
            Add(product, 1);
        }

        public void Add(Product product, int count)
        {
            if(count < 0) throw new ArgumentOutOfRangeException("count");

            ProductLine productLine = GetByProduct(product) + count ?? new ProductLine(product, count);
            SetByProduct(productLine);
        }

        public void Subtract(Product product)
        {
            Subtract(product, 1);
        }

        public void Subtract(Product product, int count)
        {
            if (count < 0) throw new ArgumentOutOfRangeException("count");

            ProductLine productLine = GetByProduct(product) - count ?? new ProductLine(product, 0);
            SetByProduct(productLine);
        }

        public void RemoveByProduct(Product product)
        {
            for (int i = 0; i < base.Items.Count; i++)
            {
                if (Items[i].Product == product)
                {
                    RemoveAt(i);
                }
            }
        }

        public ProductLine? GetByProduct(Product product)
        {
            foreach (ProductLine pl in Items)
            {
                if (pl.Product == product)
                {
                    return pl;
                }
            }
            return null;
        }

        public void SetByProduct(ProductLine productLine)
        {
            for(int i = 0; i < Items.Count; i++)
            {
                if(Items[i].Product == productLine.Product)
                {
                    SetItem(i, productLine);
                    return;
                }
            }
            Items.Add(productLine);
        }
    }
}
