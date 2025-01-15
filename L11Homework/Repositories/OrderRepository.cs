using L11Homework.Interfaces;
using L11Homework.Models;

namespace L11Homework.Repositories;

public class OrderRepository : IOrderRepository
{
    private Order[] _orders;
    
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