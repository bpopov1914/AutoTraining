using L11Homework.Models;
using L11Homework.Services;
using Npgsql;

namespace L11Homework;

public class BasicTests
{
    ProductService productService = new();
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetAllProducts()
    {
        IEnumerable<Product> products = productService.GetAllProducts();
        Assert.That(products, Is.Not.Null);
        Assert.That(products, Is.Not.Empty);
    }

    [Test]
    [TestCase(1, "Tablet")]
    [TestCase(2, "Smartphone")]
    public void GetProductById(int productId, string name)
    {
        Product product = productService.GetProductById(productId);
        Assert.That(product, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(product.ProductId, Is.EqualTo(productId));
            Assert.That(product.Name, Is.EqualTo(name));
        });


    }

    [Test]
    [TestCase("Tablet")]
    [TestCase("Smartphone")]
    public void AddProduct(string name)
    {
        Random rand  = new Random();
        double price = rand.Next(3000);
        int stock = rand.Next(20);
        
        var products = productService.GetAllProducts();
        List<int> existingProductIds = new List<int>();
        foreach (Product product in products)
        {
            existingProductIds.Add(product.ProductId);
        }
        int newProductId = existingProductIds.Max() + 1;
        
        productService.InsertProduct(newProductId, name, price, stock);
        
        products = productService.GetAllProducts();

        Assert.Multiple(() =>
        {
            Assert.That(products.Last().ProductId, Is.EqualTo(newProductId));
            Assert.That(products.Last().Name, Is.EqualTo(name));
            Assert.That(products.Last().Price, Is.EqualTo(price));
            Assert.That(products.Last().Stock, Is.EqualTo(stock));
        });
    }
}