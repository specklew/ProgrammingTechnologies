using System.Collections.Generic;
using Services.API;

namespace Presentation.Model.API;

public interface IUserModel
{
    IUserService Service { get; }
    IEnumerable<IUserModelData> Users { get; } 
    bool Add(int id, string name, int age);
    bool Delete(int id);
    bool Update(int id, string name, int age);
}