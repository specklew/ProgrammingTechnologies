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

        //Create

        public abstract IUser CreateCustomer(string name, int age);

        public abstract void CreateProduct(string name, string description, float price);
        
        public abstract IState CreateState(int stateId, ProductCatalog catalog);

        public abstract IOrder CreateOrder(Product product, int quantity);
        
        public abstract Event CreateEvent(IUser user, IOrder order, OrderStatus status, IState state);

        //Read

        public abstract IUser GetUser(string guid);

        public abstract Product GetProduct(string name);

        public abstract Event GetEvent(string guid);

        public abstract Event GetEvent(IUser user, IState state);

        public abstract IState GetState(int stateId);

        //Update

        public abstract void UpdateCustomer(string guid, string name, int age);

        public abstract void UpdateProduct(string name, string description, float price);

        public abstract void UpdateOrder(Product product, int quantity);

        //Delete

        public abstract void DeleteCustomer(string guid);

        public abstract void DeleteProduct(string name);

        public abstract void DeleteOrder(int guid);
    }
}
