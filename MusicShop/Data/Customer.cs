namespace MusicShop.Data
{
    public class Customer
    {
        public int Age { get; }
        public string Name { get; }
        private List<Order> orders = new List<Order>();

        public Customer(string name, int age)
        {
            this.Name = name;   
            this.Age = age;
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
    }
}