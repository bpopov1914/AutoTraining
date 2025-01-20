using L11Homework.Interfaces;
using L11Homework.Models;
using L11Homework.Repositories;

namespace L11Homework.Services;

public class OrderService
{
   ProductRepository productRepo = new();
   OrderRepository orderRepo = new();
   
   public  IEnumerable<Order> GetAllOrders()
   {
      var orders = orderRepo.GetOrders();
      return orders;
   }
   
   public void PlaceOrder(Product product, int orderId, int quantity, DateTime orderDate)
   {
      Order order = new Order(orderId, product.ProductId, quantity, orderDate);
      orderRepo.PlaceOrder(order);
      product.Stock -= order.Quantity;
      productRepo.UpdateProduct(product);
   }

   public void PrintLastOrder()
   {
      var order = orderRepo.GetOrders().Last();
      
      Console.WriteLine($"OrderId: {order.OrderId}, ProductId: {order.ProductId}, Quantity: {order.Quantity}, OrderDate: {order.OrderDate}");

   }
   public void PrintAllOrders()
   {
      var orders = orderRepo.GetOrders();
      foreach (var order in orders)
      {
         Console.WriteLine($"OrderId: {order.OrderId}, ProductId: {order.ProductId}, Quantity: {order.Quantity}, OrderDate: {order.OrderDate}");
      }
        
   }
}