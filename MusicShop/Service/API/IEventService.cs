namespace MusicShop.Service.API;

public interface IEventService
{
    IEventData GetEvent(int eventId);
    bool AddEvent(int eventId);
    bool AddEvent(int eventId, int userId, int productId);
    bool UpdateEvent(int eventId, int userId, int productId);
    bool DeleteEvent(int eventId);
}