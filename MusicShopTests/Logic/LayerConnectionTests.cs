using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShop.Data;

namespace MusicShop.Logic.Tests
{
    [TestClass]
    public class LayerConnectionTests
    {
        [TestMethod]
        public void TestLogicLayerCreation()
        {
            DataLayerAPI dataLayerAPI = DataLayerAPI.CreateDataRepository();
            LogicLayerAPI logicLayer = LogicLayerAPI.CreateLayer(dataLayerAPI);
            Assert.IsNotNull(logicLayer);
        }
    }
}
