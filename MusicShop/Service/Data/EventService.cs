using MusicShop.Data;
using MusicShop.Data.Interfaces;
using MusicShop.Service.API;

namespace MusicShop.Service.Data;

public class EventService : IEventService
{
    private readonly DataRepository _dataRepository;

    public EventService(DataRepository dataRepository)
    {
        _dataRepository = dataRepository;
    }

    private static IEventData Transform(IEvent @event)
    {
        return @event == null ? null : new EventData(@event.Id);
    }
    
    public IEventData GetEvent(int eventId)
    {
        return Transform(_dataRepository.GetEvent(eventId));
    }

    public bool AddEvent(int eventId)
    {
        return _dataRepository.AddEvent(eventId);
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