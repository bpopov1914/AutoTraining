using L11Homework.Interfaces;
using L11Homework.Models;
using L11Homework.Repositories;
using Npgsql;

namespace L11Homework.Services;

public class ProductService : ProductRepository
{
    ProductRepository productRepo = new();
    public  IEnumerable<Product> GetAllProducts()
    {
        var products = productRepo.GetAllProducts();
       
        return products;
    }

    public Product GetProductById(int productId)
    {
        Product product = productRepo.GetProductById(productId);
        Console.WriteLine($"ProductId: {product.ProductId }, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        return product;
    }

    public void InsertProduct(int productId, string name, double price, int stock)
    {
        Product product = new(productId, name, price, stock);
        productRepo.AddProduct(product);
    }

    public void UpdateProduct(int productId, string name, double price, int stock)
    {
        Product product = productRepo.GetProductById(productId);
        product.Name = name;
        product.Price = price;
        product.Stock = stock;
        productRepo.UpdateProduct(product);
    }

    public void DeleteProduct(int productId)
    {
        productRepo.DeleteProduct(productId);
    }

    public void PrintLastProduct()
    {
        var product = productRepo.GetAllProducts().Last();
        Console.WriteLine($"ProductId: {product.ProductId }, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
    }
    public void PrintAllProducts()
    {
        var products = productRepo.GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"ProductId: {product.ProductId }, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
        
    }
}