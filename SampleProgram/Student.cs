namespace SampleProgram
{
    public class Student
    {
        private int age;
        private string name;

        public Student(int age, string name)
        {
            this.age = age;
            this.name = name;
        }


        public int getAge()
        {
            return age;
        }

        public string getName()
        {
            return name;
        }
    }
}
