using System;
using Services.API;

namespace Services.Data;

public class EventData : IEventData
{
    public int Id { get; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime EventTime { get; }
    
    public EventData(int id, int userId, int productId, DateTime time)
    {
        Id = id;
        UserId = userId;
        ProductId = productId;
        EventTime = time;
    }
}