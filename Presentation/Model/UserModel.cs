using System.Collections.Generic;
using Presentation.Model.API;
using Services.API;
using Services.Data;

namespace Presentation.Model;

internal class UserModel : IUserModel
{
    internal UserModel(IUserService service = null)
    {
        Service = service ?? new UserService();
    }

    public IUserService Service { get; }

    public IEnumerable<IUserModelData> Users
    {
        get
        {
            List<IUserModelData> users = new();
            foreach (var c in Service.GetAllUsers())
            {
                users.Add(new UserModelData(c.Id, c.Name, c.Age));
            }
            return users;
        }
    }

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