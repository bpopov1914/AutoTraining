using L11Homework.Interfaces;
using L11Homework.Models;

namespace L11Homework.Repositories;

public class ProductRepository : IProductRepository
{
    private Product[] _products = new Product[0];
    
    public IEnumerable<Product> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public Product GetProductById(int productId)
    {
        throw new NotImplementedException();
    }

    public void AddProduct(Product product)
    {
        _products.Append(product);
    }

    public void UpdateProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public void DeleteProduct(int productId)
    {
        throw new NotImplementedException();
    }
}