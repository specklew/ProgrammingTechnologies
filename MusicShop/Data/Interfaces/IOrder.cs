namespace MusicShop.Data
{
    public interface IOrder
    {
        string GUID { get; }
        OrderStatus Status { get; set; }
    }
}