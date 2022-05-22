using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Data.Models;

namespace MusicShopTests.Data;

[TestClass]
public class StateDataManipulationTests
{
    private IDataLayerApi dataRepository;
    private IState state;
    private Product product;

    [TestInitialize]
    public void TestInitialize()
    {
        dataRepository = IDataLayerApi.CreateDataRepository();
        dataRepository.Connect();

        product = new Product("TestProduct", 100.0f);

        state = dataRepository.CreateState(1, dataRepository.GetProductCatalog());
    }

    [TestMethod]
    public void TestGetStateReturnNotNull()
    {
        Assert.IsNotNull(state);
    }

    [TestMethod]
    public void TestGetState()
    {
        Assert.AreEqual(1, state.Id);
    }

    [TestMethod]
    public void TestUpdateStateReturnNewData()
    {
        dataRepository.UpdateStateProductQuantity(1, product, 2);
        Assert.AreEqual(state.GetProductQuantity(product), 2);
    }

    [TestMethod]
    public void TestDeleteUserAndExceptionThrows()
    {
        dataRepository.DeleteState(1);
        Assert.ThrowsException<InvalidOperationException>(() => dataRepository.GetState(1));
    }
}