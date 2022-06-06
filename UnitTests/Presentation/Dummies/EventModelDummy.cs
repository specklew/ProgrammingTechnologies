using System.Collections.Generic;
using Presentation.Model;
using Presentation.Model.API;
using Services.API;
using Services.Data;

namespace MusicShopTests.Presentation.Dummies;

public class EventModelDummy : IEventModel
{
    internal EventModelDummy(IEventService service = null)
    {
        Service = service ?? new EventService();
        Events = new List<IEventModelData>();
    }

    public IEventService Service { get; }

    public IEnumerable<IEventModelData> Events { get; }

    public bool Add(int id, int userId, int productId)
    {
        return Service.AddEvent(id, userId, productId);
    }
    
    public bool Delete(int id)
    {
        return Service.DeleteEvent(id);
    }
    
    public bool Update(int id, int userId, int productId)
    {
        return Service.UpdateEvent(id, userId, productId);
    }
}