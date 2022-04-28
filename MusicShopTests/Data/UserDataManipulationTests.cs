using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MusicShop.Data.Tests;

[TestClass]
public class UserDataManipulationTests
{
    private DataLayerApi dataRepository;
    private IUser user;

    [TestInitialize]
    public void TestInitialize()
    {
        dataRepository = DataLayerApi.CreateDataRepository();
        dataRepository.Connect();
        dataRepository.CreateCustomer("Joe Doe", 25);
        user = dataRepository.GetUser("Joe Doe", 25);
    }

    [TestMethod]
    public void TestGetUserReturnNotNull()
    {
        Assert.IsNotNull(user);
    }

    [TestMethod]
    public void TestGetUserByGuidReturnNotNull()
    {
        IUser copy = dataRepository.GetUser(user.Guid);
        Assert.IsNotNull(copy);
        Assert.AreEqual(user.Guid, copy.Guid);
    }

    [TestMethod]
    public void TestUpdateUserReturnNewData()
    {
        dataRepository.UpdateUser(user.Guid, "John Doe", 22);
        Assert.AreEqual("John Doe", user.Name);
        Assert.AreEqual(22, user.Age);
    }

    [TestMethod]
    public void TestDeleteUserAndExceptionThrows()
    {
        dataRepository.DeleteUser(user.Guid);
        Assert.ThrowsException<Exception>(() => dataRepository.GetUser(user.Guid));
    }
}