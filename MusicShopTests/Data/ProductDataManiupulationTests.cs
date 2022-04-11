using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MusicShop.Data;

namespace MusicShop.Tests
{
    [TestClass]
    public class ProductDataManiupulationTests
    {
        private DataLayerAPI dataRepository;
        private Product product;

        [TestInitialize]
        public void TestInitialize()
        {
            dataRepository = DataLayerAPI.CreateDataRepository();
            dataRepository.Connect();
            dataRepository.CreateProduct("Bass Guitar", "Lowest-pitched string instrument", 200.0f);
            product = dataRepository.GetProduct("Bass Guitar");
        }

        [TestMethod]
        public void TestGetUserReturnNotNull()
        {
            Assert.IsNotNull(product);
            Assert.AreEqual("Bass Guitar", product.Name);
        }


        [TestMethod]
        public void TestUpdateUserReturnNewData()
        {
            dataRepository.UpdateProduct(product.Name, "Test string", 150.0f);
            Assert.AreEqual("Test string", product.Description);
            Assert.AreEqual(150.0f, product.Price);
        }

        [TestMethod]
        public void TestDeleteUserAndExceptionThrows()
        {
            dataRepository.DeleteProduct(product.Name);
            Assert.ThrowsException<Exception>(() => dataRepository.GetProduct(product.Name));
        }
    }
}
