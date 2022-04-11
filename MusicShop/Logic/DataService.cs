using MusicShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Logic
{
    public class DataService : LogicLayerAPI
    {
        private readonly DataLayerAPI dataLayer;
        public DataService(DataLayerAPI data)
        {
            dataLayer = data;
            dataLayer.Connect();
        }
        

    }
}
