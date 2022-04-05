using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    internal struct ProductLine
    {
        public Product Product { get; }
        public int NumberOfProducts { get; }

        public ProductLine(Product product, int count)
        {
            if(count < 0) throw new ArgumentOutOfRangeException("count");
            this.Product = product;
            this.NumberOfProducts = count;
        }

        public static ProductLine operator +(ProductLine a, int b) 
            => new(a.Product, a.NumberOfProducts + b);

        public static ProductLine operator -(ProductLine a, int b)
        {
            if (a.NumberOfProducts >= b)
                return new(a.Product, a.NumberOfProducts - b);
            else
                return new(a.Product, 0);
        }
    }
}
