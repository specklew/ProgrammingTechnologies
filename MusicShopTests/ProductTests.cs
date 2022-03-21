using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MusicShop
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void TestProductCatalog()
        {
            Catalog catalog = new Catalog();
            Product product1 = new Product("Fender Jaguar", 1000);
            Product product2 = new Product("Gibson Hollow Body", 2000);

            catalog.addToCatalog(1, product1);
            catalog.addToCatalog(2, product2);

            Assert.AreEqual("Fender Jaguar", catalog.getProductById(1).getName());
            Assert.AreEqual(2000, catalog.getProductById(2).getPrice());
        }
    }
}
