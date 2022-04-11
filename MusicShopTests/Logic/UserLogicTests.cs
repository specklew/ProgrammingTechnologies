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
        private String customer;

        [TestInitialize]
        public void TestInitialize()
        {
            dataRepository = DataLayerAPI.CreateDataRepository();
            logic = LogicLayerAPI.CreateLayer(dataRepository);
            logic.CreateCustomer("John Smith", 32);
            customer = logic.GetCustomerGUID("John Smith", 32);
        }

        [TestMethod]
        public void TestGetCustomerReturnNotNull()
        {
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void TestUpdateCustomerReturnNewData()
        {
            logic.UpdateCustomer(customer, "John Brown", 33);
            Assert.AreEqual(customer + " Name: John Brown, Age: 33", logic.GetCustomer(customer));
        }

        [TestMethod]
        public void TestDeleteUserAndExceptionThrows()
        {
            logic.DeleteCustomer(customer);
            Assert.ThrowsException<Exception>(() => logic.GetCustomer(logic.GetCustomer(customer)));
        }
    }
}
