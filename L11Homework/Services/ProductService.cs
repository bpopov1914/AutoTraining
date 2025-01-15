using L11Homework.Interfaces;
using L11Homework.Models;
using L11Homework.Repositories;
using Npgsql;

namespace L11Homework.Services;

public class ProductService : ProductRepository
{
    Database.Database database = new();
    ProductRepository productRepo = new();
    public void GetAllProducts()
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
                        var product = new Product();
                        product.ProductId = reader.GetInt32(0);
                        product.Name = reader.GetString(1); 
                        product.Price = reader.GetDouble(2);
                        product.Stock = reader.GetInt32(3);
                        productRepo.AddProduct(product);
                        Console.WriteLine($"ProductId: {product.ProductId }, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                    }
                }
            }

        
        }
    }
}