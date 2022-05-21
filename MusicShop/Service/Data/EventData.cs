using System;
using MusicShop.Service.API;

public class EventData : IEventData
{
    public int Id { get; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime EventTime { get; }
    
    public EventData(int id, DateTime eventTime)
    {
        Id = id;
        EventTime = eventTime;
    }
    
    public EventData(int id)
    {
        Id = id;
        EventTime = DateTime.Now;
    }
}