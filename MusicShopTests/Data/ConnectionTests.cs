using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MusicShop.Data.Tests
{
    [TestClass]
    public class ConnectionTests
    {
        [TestMethod]
        public void TestDataLayerThrowExceptionWhenGettingNotExistantState()
        {
            DataLayerAPI api = DataLayerAPI.CreateDataRepository();
            Assert.ThrowsException<InvalidOperationException>(() => api.GetState(1));
        }
    }
}
