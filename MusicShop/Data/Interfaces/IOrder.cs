namespace MusicShop.Data;

public interface IOrder
{
    string Guid { get; }
    OrderStatus Status { get; set; }
}