using System;
using System.Collections.Generic;
using Presentation.Model.API;
using Services.API;

namespace Presentation.Model;

public class EventModelData : IEventModelData
{
    public EventModelData(IEventService service)
    {
        Service = service;
    }

    public IEventService Service { get; }

    public IEnumerable<IEventData> Event => Service.GetAllEvents();

    public IEventModel Create(int id, int userId, int productId, DateTime time)
    {
        return new EventModel(id, userId, productId, time);
    }
}