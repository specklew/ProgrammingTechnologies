using System.Collections.Generic;

namespace Services.API;

public interface IUserService
{
    IEnumerable<IUserData> GetAllUsers();
    IUserData GetUser(int userId);
    bool AddUser(int userId, string userName, int userAge);
    bool UpdateUser(int userId, string userName, int userAge);
    bool DeleteUser(int userId);

}