using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MusicShop.Data.Models;

namespace MusicShop.Data.Tests;

[TestClass]
public class ProductDataManipulationTests
{
    private IDataLayerApi dataRepository;
    private Product product;

    [TestInitialize]
    public void TestInitialize()
    {
        dataRepository = IDataLayerApi.CreateDataRepository();
        dataRepository.Connect();
        dataRepository.CreateProduct("Bass Guitar", "Lowest-pitched string instrument", 200.0f);
        product = dataRepository.GetProduct("Bass Guitar");
    }

    [TestMethod]
    public void TestGetProductReturnNotNull()
    {
        Assert.IsNotNull(product);
        Assert.AreEqual("Bass Guitar", product.Name);
    }


    [TestMethod]
    public void TestUpdateProductReturnNewData()
    {
        dataRepository.UpdateProduct(product.Name, "Test string", 150.0f);
        Assert.AreEqual("Test string", product.Description);
        Assert.AreEqual(150.0f, product.Price);
    }

    [TestMethod]
    public void TestDeleteProductAndExceptionThrows()
    {
        dataRepository.DeleteProduct(product.Name);
        Assert.ThrowsException<Exception>(() => dataRepository.GetProduct(product.Name));
    }
}