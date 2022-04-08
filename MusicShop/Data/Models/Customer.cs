namespace MusicShop.Data
{
    internal class Customer : IUser
    {
        public string GUID { get; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Customer(string name, int age)
        {
            GUID = Guid.NewGuid().ToString();
            Name = name;
            Age = age;
        }
    }
}