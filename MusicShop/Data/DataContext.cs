using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    internal class DataContext
    {
        public ProductCatalog Catalog = new ProductCatalog();
        public List<Customer> Customers = new List<Customer>();
        public List<Order> Orders = new List<Order>();
        public List<Event> Events = new List<Event>();
    }
}
