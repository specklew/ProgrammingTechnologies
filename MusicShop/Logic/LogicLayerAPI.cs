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
            return new DataService(data == null ? DataLayerAPI.CreateDataRepository() : data);
        }

        /*
        So what needs to be done here??

        1. Create users, orders, products, events and states.
        2. Update users, orders and products data.
        3. Remove users, orders, products.
        4. Read all users, orders, products and events.

        ^All of these methods must be abstract here and inherited in DataService.cs
         */
    }
}
