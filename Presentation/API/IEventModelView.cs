using System;

namespace Presentation.API;

public interface IEventModelView
{
    public int Id { get; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime EventTime { get; }
}