using L11Homework.Interfaces;
using L11Homework.Models;

namespace L11Homework.Services;

public class OrderService :IOrderRepository
{
    public void PlaceOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Order> GetOrders()
    {
        throw new NotImplementedException();
    }

    public Order GetOrderById(int orderId)
    {
        throw new NotImplementedException();
    }
}