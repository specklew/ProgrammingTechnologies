using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    public abstract class DataLayerAPI
    {
        public abstract void Connect();

        private class LinqToXml : DataLayerAPI
        {
            public override void Connect()
            {
                throw new NotImplementedException();
            }
        }
    }
}
