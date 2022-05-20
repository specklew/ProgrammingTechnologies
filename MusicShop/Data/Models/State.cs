using System.Collections.Generic;

namespace MusicShop.Data;

internal class State : IState
{
    public int Id { get; set; }
    public ProductCatalog Catalog { get; }
    private Dictionary<int, int> productsQuantity = new Dictionary<int, int>();

    public State(int id, ProductCatalog catalog)
    {
        Id = id;
        Catalog = catalog;

        for (int i = 0; i < Catalog.Count; i++)
        {
            productsQuantity.Add(i, 0);
        }
    }

    public void SetProductsQuantity(Dictionary<Product, int> valuePairs)
    {
        foreach (KeyValuePair<Product, int> pair in valuePairs)
        {
            SetProductQuantity(pair.Key, pair.Value);
        }
    }

    public void SetProductQuantity(Product product, int count)
    {
        productsQuantity[Catalog.IndexOf(product)] = count;
    }

    public int GetProductQuantity(Product product)
    {
        return productsQuantity[Catalog.IndexOf(product)];
    }

    public Dictionary<Product, int> GetProductsQuantity()
    {
        Dictionary<Product, int> result = new Dictionary<Product, int>();
        foreach (KeyValuePair<int, int> pair in productsQuantity)
        {
            result.Add(Catalog[pair.Key], pair.Value);
        }
        return result;
    }
}