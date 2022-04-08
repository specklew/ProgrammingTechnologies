using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    internal class Product
    {
        public string Name { get; }
        public string Description { get; set; }
        public float Price { get; set; }

        public Product(string name, float price)
        {
            this.Name = name;
            this.Description = "This product does not have a description";
            this.Price = price;
        }

        public Product(string name, string description, float price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
    }
}
