using L11Homework.Interfaces;
using L11Homework.Models;
using Npgsql;

namespace L11Homework.Repositories;

public class ProductRepository : IProductRepository
{
    private Product[] _products = new Product[0];
    private Database.Database database = new();
    public IEnumerable<Product> GetAllProducts()
    {
        string query = "SELECT * FROM public.\"Products\"\nORDER BY \"ProductId\" ASC";
        using (var connection = new NpgsqlConnection(database.connectionString))
        {
            connection.Open();
            using (var command = new NpgsqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var index = _products.Length;
                        var product = new Product();
                        product.ProductId = reader.GetInt32(0);
                        product.Name = reader.GetString(1); 
                        product.Price = reader.GetDouble(2);
                        product.Stock = reader.GetInt32(3);
                        
                        Array.Resize(ref _products, _products.Length + 1);
                        _products[index] = product;
                    }
                }
            }
        }
        return _products;
    }

    public Product GetProductById(int productId)
    {
        throw new NotImplementedException();
    }

    public void AddProduct(Product product)
    {
        
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