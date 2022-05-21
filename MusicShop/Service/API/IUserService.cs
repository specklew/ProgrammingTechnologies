namespace MusicShop.Service.API;

public interface IUserService
{
    IUserData GetUser(int userId);
    bool AddUser(int userId, string userName, int userAge);
    bool UpdateUser(int userId, string userName, int userAge);
    bool DeleteUser(int userId);

}