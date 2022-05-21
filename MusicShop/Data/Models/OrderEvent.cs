using System;
using MusicShop.Data.Interfaces;

namespace MusicShop.Data.Models;

internal class OrderEvent : IEvent
{ 
    public int Id { get; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime EventTime { get; }
    public OrderEvent(int id, int userId, int productId, int productCount)
    {
        Id = id;
        UserId = userId;
        ProductId = productId;
        EventTime = DateTime.Now;
    }
    public OrderEvent(int id)
    {
        Id = id;
        EventTime = DateTime.Now;
    }
}