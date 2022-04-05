using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShop.Data;
using System;

namespace MusicShopTests.Data.Tests
{
    [TestClass]
    public class ConnectionTests
    {
        [TestMethod]
        public void TestDataLayerConnectionThrowNotImplementedException()
        {
            DataLayerAPI api = DataLayerAPI.CreateDataRepository();
            Assert.ThrowsException<NotImplementedException>(() => api.Connect());
        }
    }
}
