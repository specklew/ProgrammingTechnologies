using System.Collections.Generic;
using Presentation.API;
using Services.API;

namespace Presentation.Model;

public class UserModelData : IUserModelData
{
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