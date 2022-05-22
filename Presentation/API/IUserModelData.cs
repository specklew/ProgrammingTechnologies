using System.Collections.Generic;
using Services.API;

namespace Presentation.API;

public interface IUserModelData
{
    IUserService Service { get; }
    IEnumerable<IUserData> User { get; } 
    IUserModelView CreateUser(int id, string name, int age);
}