using System.Transactions;
using L11Homework.Models;
using L11Homework.Services;
using Npgsql;

namespace L11Homework;

public class BasicTests
{
    ProductService productService = new();
    OrderService orderService = new();
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetAllProducts()
    {
        List<Product> products = productService.GetAllProducts().ToList();
        productService.PrintAllProducts();
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
        
        var products = productService.GetAllProducts().ToList();
        List<int> existingProductIds = new List<int>();
        foreach (Product product in products)
        {
            existingProductIds.Add(product.ProductId);
        }
        int newProductId = existingProductIds.Max() + 1;
        
        productService.InsertProduct(newProductId, name, price, stock);
        
        products = productService.GetAllProducts().ToList();
        productService.PrintLastProduct();
        Assert.Multiple(() =>
        {
            Assert.That(products.Last().ProductId, Is.EqualTo(newProductId));
            Assert.That(products.Last().Name, Is.EqualTo(name));
            Assert.That(products.Last().Price, Is.EqualTo(price));
            Assert.That(products.Last().Stock, Is.EqualTo(stock));
        });
    }

    [Test]
    [TestCase("Tablet")]
    public void UpdateProduct(string name)
    {
        Random rand  = new Random();
        double price = rand.Next(3000);
        int stock = rand.Next(20);
        
        var products = productService.GetAllProducts().ToList();
        List<int> existingProductIds = new List<int>();
        foreach (Product product in products)
        {
            existingProductIds.Add(product.ProductId);
        }

        int newProductId = existingProductIds.Max() + 1;
        productService.InsertProduct(newProductId, name, price, stock);
        var productsAfterInsert = productService.GetAllProducts().ToList();
        Assert.That(productsAfterInsert.Last().ProductId, Is.EqualTo(newProductId));
        productService.PrintLastProduct();
        productService.UpdateProduct(newProductId, "Tablet Updated", 250, 5);
        productService.PrintLastProduct();
        var productsAfterUpdate = productService.GetAllProducts().ToList();
        Assert.Multiple(() =>
        {
            Assert.That(productsAfterUpdate.Last().ProductId, Is.EqualTo(newProductId));
            Assert.That(productsAfterUpdate.Last().Name, Is.EqualTo("Tablet Updated"));;
            Assert.That(productsAfterUpdate.Last().Price, Is.EqualTo(250));
            Assert.That(productsAfterUpdate.Last().Stock, Is.EqualTo(5));
        });
    }
    
    [Test]
    [TestCase("Tablet")]
    public void DeleteProduct(string name)
    {
        Random rand  = new Random();
        double price = rand.Next(3000);
        int stock = rand.Next(20);
        
        var products = productService.GetAllProducts().ToList();
        List<int> existingProductIds = new List<int>();
        foreach (Product product in products)
        {
            existingProductIds.Add(product.ProductId);
        }

        int newProductId = existingProductIds.Max() + 1;
        productService.InsertProduct(newProductId, name, price, stock);
        var productsAfterInsert = productService.GetAllProducts().ToList();
        Assert.That(productsAfterInsert.Last().ProductId, Is.EqualTo(newProductId));
        productService.PrintAllProducts();
        productService.DeleteProduct(newProductId);
        productService.PrintAllProducts();
        var productsAfterDelete = productService.GetAllProducts().ToList();
        Assert.That(productsAfterDelete.Last().ProductId, Is.EqualTo(newProductId - 1));
    }
    
    [Test]
    //[TestCase("Tablet")]
    [TestCase("Smartphone")]
    public void PlaceOrder(string name)
    {
        Random rand  = new Random();
        double price = rand.Next(3000);
        int stock = rand.Next(20);
        
        var products = productService.GetAllProducts().ToList();
        List<int> existingProductIds = new List<int>();
        foreach (Product product in products)
        {
            existingProductIds.Add(product.ProductId);
        }

        int newProductId = existingProductIds.Max() + 1;
        productService.InsertProduct(newProductId, name, price, stock);
        var productsAfterInsert = productService.GetAllProducts().ToList();
        Assert.That(productsAfterInsert.Last().ProductId, Is.EqualTo(newProductId));
        
        var orders = orderService.GetAllOrders().ToList();
        List<int> existingOrderIds = new List<int>();
        foreach (Order order in orders)
        {
            existingOrderIds.Add(order.OrderId);
        }
        var newProduct = productService.GetProductById(newProductId);
        int orderId = existingOrderIds.Max() + 1;
        int quantity = rand.Next(0, newProduct.Stock);
        DateTime orderDate = DateTime.Now;
        orderService.PlaceOrder(newProduct, orderId, quantity, orderDate);
        var ordersAfterOrderPlaced = orderService.GetAllOrders().ToList();
        var productsAfterOrderPlaced = productService.GetAllProducts().ToList();
        productService.PrintLastProduct();
        orderService.PrintLastOrder();
        Assert.That(ordersAfterOrderPlaced.Last().OrderId, Is.EqualTo(orderId));
        Assert.That(productsAfterOrderPlaced.Last().Stock, Is.EqualTo(productsAfterInsert.Last().Stock - quantity));
    }
}