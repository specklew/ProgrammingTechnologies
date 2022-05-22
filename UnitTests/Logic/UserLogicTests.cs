using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace MusicShopTests.Logic;

[TestClass]
public class UserLogicTests
{
    private IDataLayerApi dataRepository;
    private LogicLayerApi logic;
    private String customer;

    [TestInitialize]
    public void TestInitialize()
    {
        dataRepository = IDataLayerApi.CreateDataRepository();
        logic = LogicLayerApi.CreateLayer(dataRepository);
        logic.CreateCustomer("John Smith", 32);
        customer = logic.GetCustomerGuid("John Smith", 32);
    }

    [TestMethod]
    public void TestGetCustomerReturnNotNull()
    {
        Assert.IsNotNull(customer);
    }

    [TestMethod]
    public void TestUpdateCustomerReturnNewData()
    {
        logic.UpdateCustomer(customer, "John Brown", 33);
        Assert.AreEqual(customer + " Name: John Brown, Age: 33", logic.GetCustomer(customer));
    }

    [TestMethod]
    public void TestDeleteUserAndExceptionThrows()
    {
        logic.DeleteCustomer(customer);
        Assert.ThrowsException<Exception>(() => logic.GetCustomer(logic.GetCustomer(customer)));
    }
}