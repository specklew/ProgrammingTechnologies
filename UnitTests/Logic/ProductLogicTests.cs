using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.API;
using Services.Data;

namespace MusicShopTests.Logic;

[TestClass]
public class ProductLogicTests
{
    private IProductService _service;

    [TestInitialize]
    public void TestInitialize()
    {
        _service = new ProductService();
        
        _service.NukeData();
        
        _service.AddProduct(0, "Harp", "47 strings", 1500.0f);
    }
    
    [TestMethod]
    public void TestGetProductReturnNotNull()
    {
        Assert.IsNotNull(0);
        Assert.AreEqual("Harp", _service.GetProduct(0).Name);
    }
    
    [TestMethod]
    public void TestUpdateProductReturnNewData()
    {
        _service.UpdateProduct(0, "Harp", "50 strings", 1600.0f);
        Assert.AreEqual(1600.0f, _service.GetProduct(0).Price);
    }
}