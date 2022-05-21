using MusicShop.Data.Interfaces;

namespace MusicShop.Data;

public interface IDataLayerApi
{
    IUser Transform(Users user);
    IEvent Transform(Events events);
    IProduct Transform(Products product);

    //CRUD:
    #region User

    IUser GetUser(int userId);
    bool AddUser(int userId, string userName, int userAge);
    bool UpdateUser(int userId, string userName, int userAge);
    bool DeleteUser(int userId);

    #endregion

    #region Event

    IEvent GetEvent(int eventId);
    bool AddEvent(int eventId);
    bool AddEvent(int eventId, int userId, int productId);
    bool UpdateEvent(int eventId, int userId, int productId);
    bool DeleteEvent(int eventId);

    #endregion

    #region Product

    IProduct GetProduct(int productId);
    bool AddProduct(int productId, string name, float price);
    bool AddProduct(int productId, string name, string description, float price);
    bool UpdateProduct(int productId, string name, string description, float price);
    bool DeleteProduct(int productId);

    #endregion
}