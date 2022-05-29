using System;
using Presentation.API;

namespace Presentation.Model;

public class EventModelView : IEventModelView
{
    public int Id { get; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime EventTime { get; }
    public EventModelView(int id, int userId, int productId, DateTime time)
    {
        Id = id;
        UserId = userId;
        ProductId = productId;
        EventTime = time;
    }
}