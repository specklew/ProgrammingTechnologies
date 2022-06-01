using System.Collections.Generic;
using Presentation.Model.API;
using Services.API;
using Services.Data;

namespace Presentation.Model;

public class EventModel : IEventModel
{
    internal EventModel(IEventService service = null)
    {
        Service = service ?? new EventService();
    }

    public IEventService Service { get; }

    public IEnumerable<IEventModelData> Events
    {
        get
        {
            List<IEventModelData> events = new();
            foreach (var data in Service.GetAllEvents())
            {
                events.Add(new EventModelData(data.Id, data.UserId, data.ProductId, data.EventTime));
            }
            return events;
        }
    }

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