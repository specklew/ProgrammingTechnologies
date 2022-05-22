using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace MusicShopTests.Logic;

[TestClass]
public class LayerConnectionTests
{
    [TestMethod]
    public void TestLogicLayerCreation()
    {
        IDataLayerApi dataLayerApi = IDataLayerApi.CreateDataRepository();
        LogicLayerApi logicLayer = LogicLayerApi.CreateLayer(dataLayerApi);
        Assert.IsNotNull(logicLayer);
    }
}