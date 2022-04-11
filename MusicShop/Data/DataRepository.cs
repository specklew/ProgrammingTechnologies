namespace MusicShop.Data
{
    internal class DataRepository : DataLayerAPI
    {
        private readonly DataContext context;
        public DataRepository(DataContext data)
        {
            context = data;
        }

        public override void Connect()
        {
            //This function when implemented could handle the loading of the product catalog,
            //but I'm just to lazy to implement it... :/
        }

        
        //Data manipulation:
        //Create, Read, Update, Delete.

        //State:

        public override void CreateState(int stateId, ProductCatalog catalog)
        {
            context.States.Add(new State(stateId, catalog));
        }

        public override IState GetState(int stateId)
        {
            return context.States.First(s => s.Id == stateId);
        }
   
        public override void UpdateStateProductQuantity(int stateId, Product product, int quantity) 
        {
            GetState(stateId).SetProductQuantity(product, quantity);
        }

        public override void UpdateStateProductsQuantity(int stateId, Dictionary<Product, int> productsQuantities)
        {
            GetState(stateId).SetProductsQuantity(productsQuantities);
        }

        public override void DeleteState(int stateId)
        {
            context.States.Remove(GetState(stateId));
        }

        //Event:

        public override string CreateOrderEvent(IUser user, IOrder order, OrderStatus status, IState state) 
        {
            OrderEvent orderEvent = new OrderEvent(user, order, status, state);
            context.Events.Add(orderEvent);
            return orderEvent.GUID;
        }

        public override Event GetEvent(IUser user, IState state)
        {
            foreach(Event @event in context.Events)
            {
                if(@event.User == user && @event.ShopState == state)
                {
                    return @event;
                }
            }
            throw new Exception("No event with these parameters was found!");
        }

        public override Event GetEvent(string guid)
        {
            foreach(Event @event in context.Events)
            {
                if(@event.GUID == guid) return @event;
            }
            throw new Exception("Event with guid = '" + guid + "' does not exist!");
        }

        public override void DeleteEvent(string guid)
        {
            context.Events.Remove(GetEvent(guid));   
        }

        //Catalog:

        public override void CreateProduct(string name, string description, float price)
        {
            context.Catalog.Add(new Product(name, description, price));
        }

        public override Product GetProduct(string name)
        {
            foreach(Product product in context.Catalog)
            {
                if(product.Name == name)
                {
                    return product;
                }
            }
            throw new Exception("The product with the name = '" + name + "' does not exist!");
        }

        public override void UpdateProduct(string name, string description, float price)
        {
            Product product = GetProduct(name);

            product.Description = description;
            product.Price = price;
        }

        public override void DeleteProduct(string name)
        {
            context.Catalog.Remove(GetProduct(name));
        }

        //IUser:

        public override void CreateCustomer(string name, int age)
        {
            context.Users.Add(new Customer(name, age));
        }

        public override IUser GetUser(string guid)
        {
            foreach(IUser user in context.Users)
            {
                if(user.GUID == guid) return user;
            }

            throw new Exception("User with the GUID = '" + guid + "' not found");
        }

        public override IUser GetUser(string name, int age)
        {
            return context.Users.First(user => user.Name == name && user.Age == age);
        }

        public override void UpdateUser(string guid, string name, int age)
        {
            IUser user = GetUser(guid);

            user.Name = name;
            user.Age = age;
        }

        public override void DeleteUser(string guid)
        {
            context.Users.Remove(GetUser(guid));
        }
    }
}
