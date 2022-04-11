using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShop.Data;
using System;

namespace MusicShop.Tests
{
    [TestClass]
    public class UserDataManipulationTests
    {
        private DataLayerAPI dataRepository;
        private IUser user;

        [TestInitialize]
        public void TestInitialize()
        {
            dataRepository = DataLayerAPI.CreateDataRepository();
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
            IUser copy = dataRepository.GetUser(user.GUID);
            Assert.IsNotNull(copy);
            Assert.AreEqual(user.GUID, copy.GUID);
        }

        [TestMethod]
        public void TestUpdateUserReturnNewData()
        {
            dataRepository.UpdateUser(user.GUID, "John Doe", 22);
            Assert.AreEqual("John Doe", user.Name);
            Assert.AreEqual(22, user.Age);
        }

        [TestMethod]
        public void TestDeleteUserAndExceptionThrows()
        {
            dataRepository.DeleteUser(user.GUID);
            Assert.ThrowsException<Exception>(() => dataRepository.GetUser(user.GUID));
        }
    }
}