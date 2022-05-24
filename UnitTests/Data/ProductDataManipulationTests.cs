using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Data.Interfaces;

namespace MusicShopTests.Data;

[TestClass]
public class ProductDataManipulationTests
{
    private IDataLayerApi _dataRepository;
    private IProduct _product;

    [TestInitialize]
    public void TestInitialize()
    {
        _dataRepository = new DataRepository();

        _dataRepository.NukeData();
        
        _dataRepository.AddProduct(0, "Bass Guitar", "Pluck, pluck, bass goes brrr", 200.0f);
        _product = _dataRepository.GetProduct(0);
    }

    [TestMethod]
    public void TestGetProductReturnNotNull()
    {
        Assert.IsNotNull(_product);
        Assert.AreEqual("Bass Guitar", _product.Name);
    }


    [TestMethod]
    public void TestUpdateProductReturnNewData()
    {
        _dataRepository.UpdateProduct(0, "Test string","Test description", 150.0f);
        Assert.AreEqual("Test string", _dataRepository.GetProduct(0).Name);
        Assert.AreEqual(150.0f, _dataRepository.GetProduct(0).Price);
    }

    [TestMethod]
    public void TestDeleteProductAndExceptionThrows()
    {
        _dataRepository.DeleteProduct(0);
        Assert.IsFalse(_dataRepository.DeleteProduct(0));
    }
}