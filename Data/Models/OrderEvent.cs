using System;
using Data.Interfaces;

namespace Data.Models;

internal class OrderEvent : IEvent
{ 
    public int Id { get; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime EventTime { get; }
    public OrderEvent(int id, int userId, int productId)
    {
        Id = id;
        UserId = userId;
        ProductId = productId;
        EventTime = DateTime.Now;
    }
}