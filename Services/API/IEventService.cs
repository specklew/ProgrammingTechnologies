using System.Collections.Generic;

namespace Services.API;

public interface IEventService
{
    IEnumerable<IEventData> GetAllEvents();
    IEventData GetEvent(int eventId);
    bool AddEvent(int eventId);
    bool AddEvent(int eventId, int userId, int productId);
    bool UpdateEvent(int eventId, int userId, int productId);
    bool DeleteEvent(int eventId);
}