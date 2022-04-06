using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    internal class DataContext
    {
        public ProductCatalog Catalog = new();
        public List<Customer> Customers = new();
        public List<State> States = new();
        public List<Event> Events = new();
    }
}
