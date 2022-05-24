using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace MusicShopTests.Data;

[TestClass]
public class EventDataManiupulationTests
{
    private IDataLayerApi _dataRepository;

    [TestInitialize]
    public void TestInitialize()
    {
        _dataRepository = new DataRepository();
        
        _dataRepository.NukeData();
        
        _dataRepository.AddUser(0, "Joe Doe", 25);
        _dataRepository.AddProduct(0, "Bass Guitar", "Pluck, pluck, bass goes brrr", 200.0f);
        _dataRepository.AddEvent(0, 0, 0);
    }

    [TestMethod]
    public void TestGetProductReturnNotNull()
    {
        Assert.IsNotNull(_dataRepository.GetProduct(0));
    }


    [TestMethod]
    public void TestDeleteProductAndExceptionThrows()
    {
        _dataRepository.DeleteEvent(0);
        Assert.IsFalse(_dataRepository.DeleteEvent(0));
    }
}