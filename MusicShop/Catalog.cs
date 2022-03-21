namespace MusicShop
{
    public class Catalog
    {
        private Dictionary<int, Product> products = new Dictionary<int, Product>();

        public void addToCatalog(int id, Product product)
        {
            products.Add(id, product);
        }

        public Product getProductById(int id)
        {
            return products[id];
        }
    }
}
