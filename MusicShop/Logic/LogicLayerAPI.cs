using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShop.Data;

namespace MusicShop.Logic
{
    public abstract class LogicLayerAPI
    {
        public static LogicLayerAPI CreateLayer(DataLayerAPI? data = default)
        {
            return new LogicLayer(data == null ? DataLayerAPI.CreateDataRepository() : data);
        }

        private class LogicLayer : LogicLayerAPI
        {
            public LogicLayer(DataLayerAPI data)
            {
                dataLayer = data;
                dataLayer.Connect();
            }
            private readonly DataLayerAPI dataLayer;
        }
    }
}
