using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    public abstract class DataLayerAPI
    {
        internal DataContext? context;
        public abstract void Connect();

        public static DataLayerAPI CreateDataRepository()
        {
            //TODO: implement the data generation for data context.
            DataContext data = new DataContext();
            return new DataRepository(data);
        }
    }
}
