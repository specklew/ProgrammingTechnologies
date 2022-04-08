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
        public List<IUser> Users = new();
        public List<IState> States = new();
        public List<Event> Events = new();
    }
}
