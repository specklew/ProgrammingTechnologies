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

        //Create

        public abstract void CreateCustomer(string name, int age);

        public abstract void CreateProduct(string name, string description, float price);
        
        public abstract void CreateState(int stateId, ProductCatalog catalog);

        public abstract void CreateOrder(Product product, int quantity);
        
        public abstract void CreateEvent(IUser user, IOrder order, OrderStatus status, IState state);

        //Read

        public abstract String GetCustomer(string guid);

        public abstract String GetProduct(string name);

        public abstract String GetState(int stateId);

        public abstract String GetEvent(string guid);

        //Update

        public abstract void UpdateCustomer(string guid, string name, int age);

        public abstract void UpdateProduct(string name, string description, float price);

        //Delete

        public abstract void DeleteCustomer(string guid);

        public abstract void DeleteProduct(string name);

        public abstract void DeleteEvent(string guid);
    }
}
