using L11Homework.Models;
using L11Homework.Services;

namespace L11Homework;

public class OrderServiceTests
{
    ProductService productService = new();
    OrderService orderService = new();
    
    
    [Test]
    [TestCase("Tablet")]
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
        bool isProductInStock = productService.IsProductInStock(newProductId);
        int orderId = existingOrderIds.Max() + 1;
        int quantity = 0;
        DateTime orderDate = DateTime.Now;
        if (isProductInStock)
        {
            quantity = rand.Next(1, newProduct.Stock);
            orderService.PlaceOrder(newProduct, orderId, quantity, orderDate);
        }
        else
        {
            Console.WriteLine("Product not in stock!");
        }
        var ordersAfterOrderPlaced = orderService.GetAllOrders().ToList();
        var productsAfterOrderPlaced = productService.GetAllProducts().ToList();
        productService.PrintLastProduct();
        orderService.PrintLastOrder();
        Assert.That(ordersAfterOrderPlaced.Last().OrderId, Is.EqualTo(orderId));
        Assert.That(productsAfterOrderPlaced.Last().Stock, Is.EqualTo(productsAfterInsert.Last().Stock - quantity));

    }

    [Test]
    [TestCase(3)]
    public void GetOrderById(int orderId)
    {
        var order = orderService.GetOrderById(orderId);
        Assert.That(order.OrderId, Is.EqualTo(orderId));
    }

    [Test]
    [TestCase("Tablet")]
    public void DeleteProductWithOrders(string name)
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
        bool isProductInStock = productService.IsProductInStock(newProductId);
        var newProduct = productService.GetProductById(newProductId);
        int orderId = existingOrderIds.Max() + 1;
        int quantity = 0;
        DateTime orderDate = DateTime.Now;
        if (isProductInStock)
        {
            quantity = rand.Next(1, newProduct.Stock);
            orderService.PlaceOrder(newProduct, orderId, quantity, orderDate);
        }
        else
        {
            Console.WriteLine("Product not in stock!");
        }
        
        var ordersAfterOrderPlaced = orderService.GetAllOrders().ToList();
        var productsAfterOrderPlaced = productService.GetAllProducts().ToList();
        productService.PrintLastProduct();
        orderService.PrintLastOrder();
        Assert.That(ordersAfterOrderPlaced.Last().OrderId, Is.EqualTo(orderId));
        Assert.That(productsAfterOrderPlaced.Last().Stock, Is.EqualTo(productsAfterInsert.Last().Stock - quantity));
        
        orderService.DeleteOrder(newProductId);
        productService.DeleteProduct(newProductId);
        productService.PrintAllProducts();
        orderService.PrintAllOrders();
        var productsAfterDelete = productService.GetAllProducts().ToList();
        var ordersAfterDelete = orderService.GetAllOrders().ToList();
        Assert.That(productsAfterDelete.Last().ProductId, Is.EqualTo(newProductId - 1));
        Assert.That(ordersAfterDelete.Last().OrderId, Is.EqualTo(orderId - 1));
    }
}