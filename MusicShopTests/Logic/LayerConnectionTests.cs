using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShop.Data;
using System;

namespace MusicShop.Logic.Tests
{
    [TestClass]
    public class LayerConnectionTests
    {
        [TestMethod]
        public void TestLogicLayerCreation()
        {
            DataLayerAPI dataLayerAPI = DataLayerAPI.CreateDataRepository();
            Assert.ThrowsException<NotImplementedException>(() => LogicLayerAPI.CreateLayer(dataLayerAPI));
        }
    }
}
