using System;

namespace Data.Interfaces;

public interface IEvent
{
    public int Id { get; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime EventTime { get; }
}