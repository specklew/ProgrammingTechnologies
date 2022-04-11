using MusicShop.Data;

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

        //Create

        public override void CreateCustomer(string name, int age)
        {
            dataLayer.CreateCustomer(name, age);
        }

        public override void CreateProduct(string name, string description, float price)
        {
            dataLayer.CreateProduct(name, description, price);
        }

        public override void CreateState(int stateId, ProductCatalog catalog)
        {
            dataLayer.CreateState(stateId, catalog);
        }

        public override void CreateOrder(Product product, int quantity)
        {
            dataLayer.CreateOrder(product, quantity);
        }

        public override void CreateEvent(IUser user, IOrder order, OrderStatus status, IState state)
        {
            dataLayer.CreateOrderEvent(user, order, status, state);
        }

        //Read

        public override String GetCustomer(string guid)
        {
            IUser customer = dataLayer.GetUser(guid);
            return customer.GUID + " Name: " + customer.Name + ", Age: " + customer.Age;
        }

        public override string GetCustomer(string name, int age)
        {
            IUser customer = dataLayer.GetUser(name, age);
            return customer.GUID + " Name: " + customer.Name + ", Age: " + customer.Age;
        }

        public override string GetCustomerGUID(string name, int age)
        {
            return dataLayer.GetUser(name, age).GUID;
        }

        public override String GetProduct(string name)
        {
            Product product = dataLayer.GetProduct(name);
            return "Name: " + product.Name + ", Description: " 
                + product.Description + ", Price: " + product.Price;
        }

        public override String GetState(int stateId)
        {
            IState state = dataLayer.GetState(stateId);
            return state.Id + " Catalog: " + state.Catalog;
        }

        public override String GetEvent(string guid)
        {
            Event ev = dataLayer.GetEvent(guid);
            return ev.GUID + " Customer: " + ev.User + " , Shop state: " 
                + ev.ShopState + " , Date: " + ev.EventTime;
        }

        //Update

        public override void UpdateCustomer(string guid, string name, int age)
        {
            dataLayer.UpdateUser(guid, name, age);
        }

        public override void UpdateProduct(string name, string description, float price)
        {
            dataLayer.UpdateProduct(name, description, price);
        }

        //Delete

        public override void DeleteCustomer(string guid)
        {
            dataLayer.DeleteUser(guid);
        }

        public override void DeleteProduct(string name)
        {
            dataLayer.DeleteProduct(name);
        }

        public override void DeleteEvent(string guid)
        {
            dataLayer.DeleteEvent(guid);
        }
    }
}
