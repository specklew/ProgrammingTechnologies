using System.Collections.Generic;
using Data.Interfaces;
using Data.Models;

namespace Data;

public class DataRepositoryDummy : IDataLayerApi
{
    private readonly List<IUser> _users = new();
    private readonly List<IEvent> _events = new();
    private readonly List<IProduct> _products = new();

    #region User

    public IEnumerable<IUser> GetAllUsers()
    {
        return _users;
    }
    
    public IUser GetUser(int userId)
    {
        return _users.Find(u => u.Id == userId);
    }

    public bool AddUser(int userId, string userName, int userAge)
    {
        IUser user = new Customer(userId, userName, userAge);
        if (_users.Contains(user)) return false;
        _users.Add(user);
        return true;
    }

    public bool UpdateUser(int userId, string userName, int userAge)
    {
        IUser user = _users.Find(u => u.Id == userId);
        if (user == null) return false;
        user.Name = userName;
        user.Age = userAge;
        return true;
    }

    public bool DeleteUser(int userId)
    {
        return _users.Remove(_users.Find(u => u.Id == userId));
    }

    #endregion

    #region Event

    public IEnumerable<IEvent> GetAllEvents()
    {
        return _events;
    }
    
    public IEvent GetEvent(int eventId)
    {
        return _events.Find(e => e.Id == eventId);
    }
    
    public bool AddEvent(int eventId, int userId, int productId)
    {
        IEvent @event = new OrderEvent(eventId, userId, productId);
        if (_events.Contains(@event)) return false;
        _events.Add(@event);
        return true;
    }

    public bool UpdateEvent(int eventId, int userId, int productId)
    {
        IEvent @event = _events.Find(e => e.Id == eventId);
        if (@event == null) return false;
        @event.UserId = userId;
        @event.ProductId = productId;
        return true;
    }

    public bool DeleteEvent(int eventId)
    {
        return _events.Remove(_events.Find(e => e.Id == eventId));
    }

    #endregion
    
    #region Product

    public IEnumerable<IProduct> GetAllProducts()
    {
        return _products;
    }
    
    public IProduct GetProduct(int productId)
    {
        return _products.Find(p => p.Id == productId);
    }

    public bool AddProduct(int productId, string name, int price)
    {
        IProduct product = new Product(productId, name, "This product doesn't have a description!", price);
        if (_products.Contains(product)) return false;
        _products.Add(product);
        return true;
    }

    public bool AddProduct(int productId, string name, string description, int price)
    {
        IProduct product = new Product(productId, name, description, price);
        if (_products.Contains(product)) return false;
        _products.Add(product);
        return true;
    }

    public bool UpdateProduct(int productId, string name, string description, int price)
    {
        IProduct product = _products.Find(p => p.Id == productId);
        if (product == null) return false;
        product.Name = name;
        product.Description = description;
        product.Price = price;
        return true;
    }

    public bool DeleteProduct(int productId)
    {
        return _products.Remove(_products.Find(p => p.Id == productId));
    }

    #endregion
    
    public void NukeData()
    {
        _users.Clear();
        _events.Clear();
        _products.Clear();
    }
}