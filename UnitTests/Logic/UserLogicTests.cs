using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.API;
using Services.Data;

namespace MusicShopTests.Logic;

[TestClass]
public class UserLogicTests
{
    private IUserService _service;

    [TestInitialize]
    public void TestInitialize()
    {
        _service = new UserService();
        
        _service.NukeData();
        
        _service.AddUser(0, "John Smith", 32);
    }
    
    [TestMethod]
    public void TestGetCustomerReturnNotNull()
    {
        Assert.IsNotNull(_service.GetUser(0));
    }
    
    [TestMethod]
    public void TestUpdateCustomerReturnNewData()
    {
        _service.UpdateUser(0, "John Brown", 33);
        
        Assert.AreEqual("John Brown", _service.GetUser(0).Name);
        Assert.AreEqual(33, _service.GetUser(0).Age);
    }
}