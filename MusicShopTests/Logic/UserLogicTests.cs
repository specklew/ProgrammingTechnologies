using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShop.Data;
using System;

namespace MusicShop.Logic.Tests
{
    [TestClass]
    public class UserLogicTests
    {
        private DataLayerAPI dataRepository;
        private LogicLayerAPI logic;
        private IUser customer;

        [TestInitialize]
        public void TestInitialize()
        {
            dataRepository = DataLayerAPI.CreateDataRepository();
            dataRepository.Connect();
            logic.CreateCustomer("John Smith", 32);
        }

        [TestMethod]
        public void TestGetCustomerReturnNotNull()
        {
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void TestUpdateCustomerReturnNewData()
        {
            logic.UpdateCustomer(customer.GUID, "John Brown", 33);
            Assert.AreEqual("John Brown", customer.Name);
            Assert.AreEqual(33, customer.Age);
        }

        [TestMethod]
        public void TestDeleteUserAndExceptionThrows()
        {
            logic.DeleteCustomer(customer.GUID);
            Assert.ThrowsException<Exception>(() => logic.GetCustomer(customer.GUID));
        }
    }
}
