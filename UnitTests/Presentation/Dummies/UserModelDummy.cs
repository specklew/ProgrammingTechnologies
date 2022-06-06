using System.Collections.Generic;
using Presentation.Model.API;
using Services.API;
using Services.Data;

namespace MusicShopTests.Presentation.Dummies;

internal class UserModelDummy : IUserModel
{
    internal UserModelDummy(IUserService service = null)
    {
        Service = service ?? new UserService();
        Users = new List<IUserModelData>();
    }

    public IUserService Service { get; }

    public IEnumerable<IUserModelData> Users { get; }

    public bool Add(int id, string name, int age)
    {
        return Service.AddUser(id, name, age);
    }
    
    public bool Delete(int id)
    {
        return Service.DeleteUser(id);
    }
    
    public bool Update(int id, string name, int age)
    {
        return Service.UpdateUser(id, name, age);
    }
}