using System.Collections.Generic;
using Data.Interfaces;

namespace Data;

public interface IDataLayerApi
{
    //CRUD:
    #region User

    IEnumerable<IUser> GetAllUsers();
    IUser GetUser(int userId);
    bool AddUser(int userId, string userName, int userAge);
    bool UpdateUser(int userId, string userName, int userAge);
    bool DeleteUser(int userId);

    #endregion

    #region Event
    
    IEnumerable<IEvent> GetAllEvents();
    IEvent GetEvent(int eventId);
    bool AddEvent(int eventId, int userId, int productId);
    bool UpdateEvent(int eventId, int userId, int productId);
    bool DeleteEvent(int eventId);

    #endregion

    #region Product

    IEnumerable<IProduct> GetAllProducts();
    IProduct GetProduct(int productId);
    bool AddProduct(int productId, string name, int price);
    bool AddProduct(int productId, string name, string description, int price);
    bool UpdateProduct(int productId, string name, string description, int price);
    bool DeleteProduct(int productId);

    #endregion

    public void NukeData();
}