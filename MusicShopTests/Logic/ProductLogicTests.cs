using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShop.Data;
using System;

namespace MusicShop.Logic.Tests;

[TestClass]
public class ProductLogicTests
{
    private DataLayerApi dataRepository;
    private LogicLayerApi logic;
    private String product;

    [TestInitialize]
    public void TestInitialize()
    {
        dataRepository = DataLayerApi.CreateDataRepository();
        logic = LogicLayerApi.CreateLayer(dataRepository);
        logic.CreateProduct("Harp", "47 strings", 1500.0f);
        product = logic.GetProduct("Harp");
    }

    [TestMethod]
    public void TestGetProductReturnNotNull()
    {
        Assert.IsNotNull(product);
        Assert.AreEqual("Name: Harp, Description: 47 strings, Price: 1500", product);
    }

    [TestMethod]
    public void TestUpdateProductReturnNewData()
    {
        logic.UpdateProduct("Harp", "50 strings", 1600.0f);
        Assert.AreEqual("Name: Harp, Description: 50 strings, Price: 1600", logic.GetProduct("Harp"));
    }

    [TestMethod]
    public void TestDeleteProductAndExceptionThrows()
    {
        logic.DeleteProduct("Harp");
        Assert.ThrowsException<Exception>(() => logic.GetProduct("Harp"));
    }
}