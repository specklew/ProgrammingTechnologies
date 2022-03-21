using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop
{
    public class Product
    {
        private string name;
        private float price;

        public Product(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public string getName() { return name; }
        public float getPrice() { return price; }
    }
}
