using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MusicShop.Data.Tests
{
    [TestClass]
    public class ProductCatalogTests
    {
        //This tests are now commented out because of accessibility changes in the data layer.

        /*[TestMethod]
        public void TestProductCatalogAddSingleItems()
        {
            ProductCatalog catalog = new ProductCatalog();
            Product product1 = new Product("Fender Jaguar", 1000);
            Product product2 = new Product("Gibson Hollow Body", 2000);

            catalog.Add(product1);
            catalog.Add(product2);

            Assert.AreEqual("Fender Jaguar", catalog[0].Product.getName());
            Assert.AreEqual(2000, catalog[1].Product.getPrice());
        }

        [TestMethod]
        public void TestProductCatalogAddMultiple()
        {
            ProductCatalog catalog = new ProductCatalog();
            Product product1 = new Product("Fender Jaguar", 1000);

            catalog.Add(product1, 10);
            catalog.Add(product1);

            Assert.AreEqual(11, catalog[0].NumberOfProducts);
        }*/
    }
}
