using L11Homework.Interfaces;
using L11Homework.Models;
using L11Homework.Repositories;
using Npgsql;

namespace L11Homework.Services;

public class ProductService : ProductRepository
{
    ProductRepository productRepo = new();
    public void GetAllProducts()
    {
        var products = productRepo.GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"ProductId: {product.ProductId }, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
    }
}