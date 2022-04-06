using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MusicShop.Data.Tests
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
