using System.Collections.Generic;

namespace MusicShop.Data;

public abstract class DataLayerApi
{
    public abstract void Connect();

    public static DataLayerApi CreateDataRepository()
    {
        DataContext data = new DataContext();
        return new DataRepository(data);
    }

    public abstract IState CreateState(int stateId, ProductCatalog catalog);

    public abstract IState GetState(int stateId);

    public abstract void UpdateStateProductQuantity(int stateId, Product product, int quantity);

    public abstract void UpdateStateProductsQuantity(int stateId, Dictionary<Product, int> productsQuantities);

    public abstract void DeleteState(int stateId);

    public abstract IOrder CreateOrder(Product product, int quantity);
    public abstract IOrder CreateOrder(Dictionary<Product, int> productLines);

    public abstract Event CreateOrderEvent(IUser user, IOrder order, OrderStatus status, IState state);
    public abstract Event GetEvent(IUser user, IState state);

    public abstract Event GetEvent(string guid);

    public abstract void DeleteEvent(string guid);

    public abstract ProductCatalog GetProductCatalog();

    public abstract void CreateProduct(string name, string description, float price);

    public abstract Product GetProduct(string name);

    public abstract void UpdateProduct(string name, string description, float price);

    public abstract void DeleteProduct(string name);

    public abstract IUser CreateCustomer(string name, int age);
    public abstract IUser GetUser(string guid);
    public abstract IUser GetUser(string name, int age);

    public abstract void UpdateUser(string guid, string name, int age);

    public abstract void DeleteUser(string guid);
}