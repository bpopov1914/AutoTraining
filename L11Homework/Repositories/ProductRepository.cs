using L11Homework.Interfaces;
using L11Homework.Models;
using Npgsql;
using NpgsqlTypes;

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
        var product = new Product();
        string query = $"SELECT * FROM public.\"Products\"\nWHERE \"ProductId\" = {productId}";
        using (var connection = new NpgsqlConnection(database.connectionString))
        {
            connection.Open();
            using (var command = new NpgsqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        product.ProductId = reader.GetInt32(0);
                        product.Name = reader.GetString(1); 
                        product.Price = reader.GetDouble(2);
                        product.Stock = reader.GetInt32(3);
                    }
                }
            }
        }

        return product;
    }

    public void AddProduct(Product product)
    {
        string query = $"INSERT INTO public.\"Products\"(\"ProductId\", \"Name\", \"Price\", \"Stock\")\nVALUES (@value1, @value2, @value3, @value4)";
        using (var connection = new NpgsqlConnection(database.connectionString))
        {
            connection.Open();
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@value1", product.ProductId);
                command.Parameters.AddWithValue("@value2", product.Name);
                command.Parameters.AddWithValue("@value3", product.Price);
                command.Parameters.AddWithValue("@value4", product.Stock);
                
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) inserted.");
            }
        }
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