using L11Homework.Models;

namespace L11Homework.Interfaces;

public interface IOrderRepository
{
    void PlaceOrder(Order order);
    IEnumerable<Order> GetOrders();
    Order GetOrderById(int orderId);

}