namespace MusicShop.Data
{
    internal class Customer : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        private List<Order> orders = new List<Order>();

        public Customer(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
    }
}