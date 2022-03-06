using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleProgram
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestStudentGetName()
        {
            Student student = new Student(10, "John Doe");

            Assert.AreEqual(student.getName(), "John Doe");
        }
    }
}