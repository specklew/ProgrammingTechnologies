using System;
using Presentation.Model.API;

namespace Presentation.Model;

public class EventModelData : IEventModelData
{
    public int Id { get; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime EventTime { get; }
    public EventModelData(int id, int userId, int productId, DateTime time)
    {
        Id = id;
        UserId = userId;
        ProductId = productId;
        EventTime = time;
    }
}