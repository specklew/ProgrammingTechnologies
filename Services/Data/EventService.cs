using System.Collections.Generic;
using Data;
using Data.Interfaces;
using Services.API;

namespace Services.Data;

public class EventService : IEventService
{
    private readonly IDataLayerApi _dataRepository;

    public EventService(IDataLayerApi dataRepository = default)
    {
        _dataRepository = dataRepository ?? new DataRepository();
    }

    private static IEventData Transform(IEvent @event)
    {
        return @event == null ? null : new EventData(@event.Id, @event.UserId, @event.UserId, @event.EventTime);
    }


    public IEnumerable<IEventData> GetAllEvents()
    {
        List<IEventData> events = new List<IEventData>();
        foreach (IEvent @event in _dataRepository.GetAllEvents())
        {
            events.Add(Transform(@event));
        }

        return events;
    }

    public IEventData GetEvent(int eventId)
    {
        return Transform(_dataRepository.GetEvent(eventId));
    }

    public bool AddEvent(int eventId, int userId, int productId)
    {
        return _dataRepository.AddEvent(eventId, userId, productId);
    }

    public bool UpdateEvent(int eventId, int userId, int productId)
    {
        return _dataRepository.UpdateEvent(eventId, userId, productId);
    }

    public bool DeleteEvent(int eventId)
    {
        return _dataRepository.DeleteEvent(eventId);
    }
}