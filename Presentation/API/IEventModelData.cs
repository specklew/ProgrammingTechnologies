using System;
using System.Collections.Generic;
using Services.API;

namespace Presentation.API;

public interface IEventModelData
{
    IEventService Service { get; }
    IEnumerable<IEventData> Event { get; } 
    IEventModelView Create(int id, int userId, int productId, DateTime time);
}