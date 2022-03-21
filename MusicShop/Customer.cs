namespace MusicShop
{
    public class Customer
    {
        private int age;
        private string name;

        public Customer(string name, int age)
        {
            this.name = name;   
            this.age = age;
        }

        public int getAge() { return age; }
        public string getName() { return name; }
    }
}