using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Data.Interfaces;

namespace MusicShopTests.Data;

[TestClass]
public class UserDataManipulationTests
{
    private IDataLayerApi _dataRepository;
    private IUser _user;

    [TestInitialize]
    public void TestInitialize()
    {
        _dataRepository = new DataRepository();
        
        _dataRepository.NukeData();
        
        _dataRepository.AddUser(0,"Joe Doe", 25);
        _user = _dataRepository.GetUser(0);
    }

    [TestMethod]
    public void TestGetUserReturnNotNull()
    {
        Assert.IsNotNull(_user);
    }

    [TestMethod]
    public void TestGetUserByGuidReturnNotNull()
    {
        IUser copy = _dataRepository.GetUser(_user.Id);
        Assert.IsNotNull(copy);
        Assert.AreEqual(_user.Id, copy.Id);
    }

    [TestMethod]
    public void TestUpdateUserReturnNewData()
    {
        _dataRepository.UpdateUser(_user.Id, "John Doe", 22);
        Assert.AreEqual("John Doe", _dataRepository.GetUser(0).Name);
        Assert.AreEqual(22, _dataRepository.GetUser(0).Age);
    }

    [TestMethod]
    public void TestDeleteUserAndExceptionThrows()
    {
        _dataRepository.DeleteUser(_user.Id);
        Assert.IsFalse(_dataRepository.DeleteUser(_user.Id));
    }
}