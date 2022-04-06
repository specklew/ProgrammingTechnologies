using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    internal class State
    {
        public int Id { get; set; }
        public ProductCatalog Catalog { get; }

        public State(int id, ProductCatalog catalog)
        {
            Id = id;
            Catalog = catalog;
        }
    }
}
