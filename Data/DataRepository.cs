using System.Collections.Generic;
using System.Linq;
using Data.Interfaces;
using Data.Models;

namespace Data;

public class DataRepository : IDataLayerApi
{
    private readonly ShopDataContext _context;
    
    public DataRepository()
    {
        _context = new ShopDataContext();
    }
    
    public DataRepository(ShopDataContext data)
    {
        _context = data;
    }
    
    public IUser Transform(Users user)
    {
        return new Customer(user.user_id, user.user_name, user.user_age);
    }

    public IEvent Transform(Events events)
    {
        return new OrderEvent(events.event_id, events.event_user, events.event_product);
    }

    public IProduct Transform(Products product)
    {
        return new Product(product.product_id, product.product_name, product.product_description,
            product.product_price);
    }


    #region User

    public IEnumerable<IUser> GetAllUsers()
    {
        var users = from user in _context.Users select Transform(user);
        return users;
    }
    
    public IUser GetUser(int userId)
    {
        var userDatabase = (from user in _context.Users where user.user_id == userId select user).FirstOrDefault();
        return userDatabase != null ? Transform(userDatabase) : null;
    }

    public bool AddUser(int userId, string userName, int userAge)
    {
        if (GetUser(userId) != null) return false;
        var newReader = new Users
        {
            user_id = userId,
            user_name = userName,
            user_age = userAge
        };
        _context.Users.InsertOnSubmit(newReader);
        _context.SubmitChanges();
        return true;
    }

    public bool UpdateUser(int userId, string userName, int userAge)
    {
        var user = _context.Users.SingleOrDefault(user => user.user_id == userId);
        if (user == null) return false;
        user.user_id = userId;
        user.user_name = userName;
        user.user_age = userAge;
        _context.SubmitChanges();
        return true;
    }

    public bool DeleteUser(int userId)
    {
        var user = _context.Users.SingleOrDefault(user => user.user_id == userId);
        if (user == null) return false;
        _context.Users.DeleteOnSubmit(user);
        _context.SubmitChanges();
        return true;
    }

    #endregion

    #region Event

    public IEnumerable<IEvent> GetAllEvents()
    {
        var events = from e in _context.Events select Transform(e);
        return events;
    }
    
    public IEvent GetEvent(int eventId)
    {
        var eventDatabase = (from events in _context.Events where events.event_id == eventId select events).FirstOrDefault();
        return eventDatabase != null ? Transform(eventDatabase) : null;
    }

    public bool AddEvent(int eventId)
    {
        if (GetEvent(eventId) != null) return false;
        var newReader = new Events
        {
            event_id = eventId
        };
        _context.Events.InsertOnSubmit(newReader);
        _context.SubmitChanges();
        return true;
    }

    public bool AddEvent(int eventId, int userId, int productId)
    {
        if (GetEvent(eventId) != null) return false;
        var newReader = new Events
        {
            event_id = eventId,
            event_user = userId,
            event_product = productId
        };
        _context.Events.InsertOnSubmit(newReader);
        _context.SubmitChanges();
        return true;
    }

    public bool UpdateEvent(int eventId, int userId, int productId)
    {
        var events = _context.Events.SingleOrDefault(events => events.event_id == eventId);
        if (events == null) return false;
        events.event_id = userId;
        events.event_user = userId;
        events.event_product = productId;
        _context.SubmitChanges();
        return true;
    }

    public bool DeleteEvent(int eventId)
    {
        var events = _context.Events.SingleOrDefault(events => events.event_id == eventId);
        if (events == null) return false;
        _context.Events.DeleteOnSubmit(events);
        _context.SubmitChanges();
        return true;
    }

    #endregion
    
    #region Product

    public IEnumerable<IProduct> GetAllProducts()
    {
        var products = from product in _context.Products select Transform(product);
        return products;
    }
    
    public IProduct GetProduct(int productId)
    {
        var productDatabase = (from product in _context.Products where product.product_id == productId select product).FirstOrDefault();
        return productDatabase != null ? Transform(productDatabase) : null;
    }

    public bool AddProduct(int productId, string name, float price)
    {
        if (GetProduct(productId) != null) return false;
        var newReader = new Products
        {
            product_id = productId,
            product_name = name,
            product_description = "This product doesn't have a description!",
            product_price = price
        };
        _context.Products.InsertOnSubmit(newReader);
        _context.SubmitChanges();
        return true;
    }

    public bool AddProduct(int productId, string name, string description, float price)
    {
        if (GetProduct(productId) != null) return false;
        var newReader = new Products
        {
            product_id = productId,
            product_name = name,
            product_description = description,
            product_price = price
        };
        _context.Products.InsertOnSubmit(newReader);
        _context.SubmitChanges();
        return true;
    }

    public bool UpdateProduct(int productId, string name, string description, float price)
    {
        var product = _context.Products.SingleOrDefault(product => product.product_id == productId);
        if (product == null) return false;
        product.product_id = productId;
        product.product_name = name;
        product.product_description = description;
        product.product_price = price;
        _context.SubmitChanges();
        return true;
    }

    public bool DeleteProduct(int productId)
    {
        var product = _context.Products.SingleOrDefault(product => product.product_id == productId);
        if (product == null) return false;
        _context.Products.DeleteOnSubmit(product);
        _context.SubmitChanges();
        return true;
    }

    #endregion
    
    public void NukeData()
    {
        _context.ExecuteCommand("DELETE FROM Events");
        _context.ExecuteCommand("DELETE FROM Products");
        _context.ExecuteCommand("DELETE FROM Users");
    }
}