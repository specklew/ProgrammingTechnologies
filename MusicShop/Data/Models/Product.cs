using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    internal class Product
    {
        private string name;
        private string description;
        private float price;

        public Product(string name, float price)
        {
            this.name = name;
            this.description = "This product does not have a description";
            this.price = price;
        }

        public Product(string name, string description, float price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }

        public string getName() { return name; }
        public string getDescription() { return description; }
        public float getPrice() { return price; }
    }
}
