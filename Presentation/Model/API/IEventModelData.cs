using System;
using System.Collections.Generic;
using Services.API;

namespace Presentation.Model.API;

public interface IEventModelData
{
    IEventService Service { get; }
    IEnumerable<IEventData> Event { get; } 
    IEventModel Create(int id, int userId, int productId, DateTime time);
}