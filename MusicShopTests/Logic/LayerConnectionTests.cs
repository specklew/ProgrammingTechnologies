using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShop.Data;

namespace MusicShop.Logic.Tests;

[TestClass]
public class LayerConnectionTests
{
    [TestMethod]
    public void TestLogicLayerCreation()
    {
        DataLayerApi dataLayerApi = DataLayerApi.CreateDataRepository();
        LogicLayerApi logicLayer = LogicLayerApi.CreateLayer(dataLayerApi);
        Assert.IsNotNull(logicLayer);
    }
}