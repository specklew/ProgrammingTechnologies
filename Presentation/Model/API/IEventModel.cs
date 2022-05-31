using System;

namespace Presentation.Model.API;

public interface IEventModel
{
    public int Id { get; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime EventTime { get; }
}