using System.Collections.Generic;
using Presentation.API;
using Services.API;
using Services.Data;

namespace Presentation.Model;

public class UserModelData : IUserModelData
{

    public UserModelData()
    {
        Service = new UserService();
    }
    
    public UserModelData(IUserService service)
    {
        Service = service;
    }

    public IUserService Service { get; }

    public IEnumerable<IUserData> User => Service.GetAllUsers();

    public IUserModelView CreateUser(int id, string name, int age)
    {
        return new UserModelView(id, name, age);
    }
}