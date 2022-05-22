using System;

namespace Services.API;

public interface IEventData
{
    public int Id { get; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime EventTime { get; }
}