using System;
using System.Collections.Generic;
using Services.API;

namespace Presentation.Model.API;

public interface IEventModel
{
    IEventService Service { get; }
    IEnumerable<IEventModelData> Events { get; }
    public bool Add(int id, int userId, int productId);
    public bool Delete(int id);
    public bool Update(int id, int userId, int productId);
}