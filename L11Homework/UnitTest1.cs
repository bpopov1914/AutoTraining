using L11Homework.Services;
using Npgsql;

namespace L11Homework;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        ProductService productService = new ProductService();
        productService.GetAllProducts();
        
    }
}