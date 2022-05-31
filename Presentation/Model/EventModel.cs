using System;
using Presentation.Model.API;

namespace Presentation.Model;

public class EventModel : IEventModel
{
    public int Id { get; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime EventTime { get; }
    public EventModel(int id, int userId, int productId, DateTime time)
    {
        Id = id;
        UserId = userId;
        ProductId = productId;
        EventTime = time;
    }
}