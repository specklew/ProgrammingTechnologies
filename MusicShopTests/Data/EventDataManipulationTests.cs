using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MusicShop.Data.Tests
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
            Assert.AreEqual(@event, dataRepository.GetEvent(@event.GUID));
        }


        [TestMethod]
        public void TestDeleteProductAndExceptionThrows()
        {
            dataRepository.DeleteEvent(@event.GUID);
            Assert.ThrowsException<Exception>(() => dataRepository.GetEvent(@event.GUID));
        }
    }
}
