using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //TODO: Implement the connection mechanism.
            throw new NotImplementedException();
        }

        
        //Data manipulation:
        //Create, Read, Update, Delete

        //Catalog:

        public void CreateProduct(string name, string description, float price)
        {
            context.Catalog.Add(new Product(name, description, price));
        }

        public Product GetProduct(string name)
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

        public void UpdateProduct(string name, string description, float price)
        {
            Product product = GetProduct(name);

            product.Description = description;
            product.Price = price;
        }

        public void DeleteProduct(string name)
        {
            context.Catalog.Remove(GetProduct(name));
        }

        //IUser:

        public void CreateCustomer(string name, int age)
        {
            context.Users.Add(new Customer(name, age));
        }

        public IUser GetUser(string guid)
        {
            foreach(IUser user in context.Users)
            {
                if(user.GUID == guid) return user;
            }

            throw new Exception("User with the GUID = '" + guid + "' not found");
        }

        public void UpdateUser(string guid, string name, int age)
        {
            IUser user = GetUser(guid);

            user.Name = name;
            user.Age = age;
        }

        public void DeleteUser(string guid)
        {
            context.Users.Remove(GetUser(guid));
        }

        
    }
}
