using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MusicShop.Data;

namespace MusicShop.Tests
{
    [TestClass]
    public class EventDataManiupulationTests
    {
        private DataLayerAPI dataRepository;
        private Event @event;

        [TestInitialize]
        public void TestInitialize()
        {
            dataRepository = DataLayerAPI.CreateDataRepository();
            dataRepository.Connect();
            // IUser, IOrder, IState:
            IUser user = dataRepository.CreateCustomer("Joe Doe", 25);
            IOrder order = dataRepository.CreateOrder(new Product("TestProduct", 100.0f), 10);
            IState state = dataRepository.CreateState(1, dataRepository.GetProductCatalog());
            @event = dataRepository.CreateOrderEvent(user, order, OrderStatus.Pending, state);
        }

        [TestMethod]
        public void TestGetProductReturnNotNull()
        {
            Assert.IsNotNull(@event);
        }


        [TestMethod]
        public void TestUpdateProductReturnNewData()
        {
            //dataRepository.UpdateProduct(@event.Name, "Test string", 150.0f);
            //Assert.AreEqual("Test string", @event.Description);
            //Assert.AreEqual(150.0f, @event.Price);
        }

        [TestMethod]
        public void TestDeleteProductAndExceptionThrows()
        {
            //dataRepository.DeleteProduct(@event.Name);
            //Assert.ThrowsException<Exception>(() => dataRepository.GetProduct(@event.Name));
        }
    }
}
