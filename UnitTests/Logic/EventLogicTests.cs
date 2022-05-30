using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.API;
using Services.Data;

namespace MusicShopTests.Logic;

[TestClass]
public class EventLogicTests
{
    private IUserService _user;
    private IProductService _product;
    private IEventService _service;

    [TestInitialize]
    public void TestInitialize()
    {
        _user = new UserService();
        _product = new ProductService();
        _service = new EventService();
        
        _service.NukeData();

        _user.AddUser(0, "Joe Doe", 22);
        _product.AddProduct(0, "Harp", "47 strings", 1500);
        _service.AddEvent(0, 0, 0);
    }
    
    [TestMethod]
    public void AddEventReturnNotNull()
    {
        Assert.IsNotNull(0);
        Assert.AreEqual(0, _service.GetEvent(0).Id);
    }
    
    [TestMethod]
    public void AddEventReturnNewData()
    {
        _user.AddUser(1, "John Doe", 23);
        _product.AddProduct(1, "Bigger Harp lol", "50 strings", 1600);
        _service.UpdateEvent(0, 1, 1);
        
        Assert.AreEqual(1, _service.GetEvent(0).UserId);
        Assert.AreEqual(1, _service.GetEvent(0).ProductId);
    }
}