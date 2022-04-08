namespace MusicShop.Data
{
    internal interface IOrder
    {
        string GUID { get; }
        OrderStatus Status { get; set; }
    }
}