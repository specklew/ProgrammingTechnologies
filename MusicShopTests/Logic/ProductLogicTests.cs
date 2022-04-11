using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShop.Data;
using System;

namespace MusicShop.Logic.Tests
{
    [TestClass]
    public class ProductLogicTests
    {
        private DataLayerAPI dataRepository;
        private LogicLayerAPI logic;
        private Product product;

        [TestInitialize]
        public void TestInitialize()
        {
            dataRepository = DataLayerAPI.CreateDataRepository();
            dataRepository.Connect();
            logic.CreateProduct("Harp", "47 strings", 1500.0f);
        }

        [TestMethod]
        public void TestGetProductReturnNotNull()
        {
            Assert.IsNotNull(product);
            Assert.AreEqual("Harp", product.Name);
        }

        [TestMethod]
        public void TestUpdateProductReturnNewData()
        {
            logic.UpdateProduct(product.Name, "50 strings", 1600.0f);
            Assert.AreEqual("50 strings", product.Description);
            Assert.AreEqual(1600.0f, product.Price);
        }

        [TestMethod]
        public void TestDeleteProductAndExceptionThrows()
        {
            logic.DeleteProduct(product.Name);
            Assert.ThrowsException<Exception>(() => logic.GetProduct(product.Name));
        }
    }
}
