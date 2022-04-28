namespace MusicShop.Data;

internal class Order : IOrder
{
    public string Guid { get; }
    public OrderStatus Status { get; set; }
    private Dictionary<Product, int> products;

    public Order(Product product, int quantity)
    {
        Guid = System.Guid.NewGuid().ToString();
        Status = OrderStatus.Pending;
        products = new Dictionary<Product, int>() {{ product, quantity }};
    }

    public Order(Dictionary<Product, int> productLines)
    {
        Guid = System.Guid.NewGuid().ToString();
        Status = OrderStatus.Pending;
        products = productLines;
    }

    public Dictionary<Product, int> GetProductsOrdered()
    {
        return products;
    }
}