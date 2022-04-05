using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    internal class DataRepository : DataLayerAPI
    {
        public DataRepository(DataContext data)
        {
            context = data;
        }

        public override void Connect()
        {
            //TODO: Implement the connection mechanism.
            throw new NotImplementedException();
        }
    }
}
