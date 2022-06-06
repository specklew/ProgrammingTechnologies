using System.Collections.Generic;
using Data;
using Data.Interfaces;
using Services.API;

namespace Services.Data;

public class UserService : IUserService
{
    private readonly IDataLayerApi _dataRepository;

    public UserService(IDataLayerApi dataRepository = default)
    {
        _dataRepository = dataRepository ?? new DataRepository();
    }

    private static IUserData Transform(IUser user)
    {
        return user == null ? null : new UserData(user.Id, user.Name, user.Age);
    }

    public IEnumerable<IUserData> GetAllUsers()
    {
        List<IUserData> users = new List<IUserData>();
        foreach (IUser user in _dataRepository.GetAllUsers())
        {
            users.Add(Transform(user));
        }

        return users;
    }

    public IUserData GetUser(int userId)
    {
        return Transform(_dataRepository.GetUser(userId));
    }

    public bool AddUser(int userId, string userName, int userAge)
    {
        return _dataRepository.AddUser(userId, userName, userAge);
    }

    public bool UpdateUser(int userId, string userName, int userAge)
    {
        return _dataRepository.UpdateUser(userId, userName, userAge);
    }

    public bool DeleteUser(int userId)
    {
        return _dataRepository.DeleteUser(userId);
    }
}