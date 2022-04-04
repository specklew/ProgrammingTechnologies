using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShop.Data;

namespace MusicShop.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void TestCustomerGetName()
        {
            Customer customer = new Customer("John Doe", 10);

            Assert.AreEqual("John Doe", customer.GetName());
        }
    }
}