using L11Homework.Interfaces;
using L11Homework.Models;
using Npgsql;

namespace L11Homework.Repositories;

public class OrderRepository : IOrderRepository
{
    private Database.Database database = new();
    
    public void PlaceOrder(Order order)
    {
        string query = "INSERT INTO public.\"Orders\"(\"OrderId\", \"ProductId\", \"Quantity\", \"OrderDate\")\nVALUES (@value1, @value2, @value3, @value4)";
        using (var connection = new NpgsqlConnection(database.connectionString))
        {
            connection.Open();
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@value1", order.OrderId);
                command.Parameters.AddWithValue("@value2", order.ProductId);
                command.Parameters.AddWithValue("@value3", order.Quantity);
                command.Parameters.AddWithValue("@value4", order.OrderDate);
                
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) inserted.");
            }
        }
    }

    public IEnumerable<Order> GetOrders()
    {
        Order[] orders = new Order[0];
        
        string query = "SELECT * FROM public.\"Orders\"\nORDER BY \"OrderId\" ASC";
        using (var connection = new NpgsqlConnection(database.connectionString))
        {
            connection.Open();
            using (var command = new NpgsqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var index = orders.Length;
                        var order = new Order();
                        order.OrderId = reader.GetInt32(0);
                        order.ProductId = reader.GetInt32(1); 
                        order.Quantity = reader.GetInt32(2);
                        order.OrderDate = reader.GetDateTime(3);
                        
                        Array.Resize(ref orders, orders.Length + 1);
                        orders[index] = order;
                    }
                }
            }
        }
         
        return orders;
    }

    public Order GetOrderById(int orderId)
    {
        var order = new Order();

        string query = $"SELECT * FROM public.\"Orders\"\nWHERE \"OrderId\" = {orderId}";
        using (var connection = new NpgsqlConnection(database.connectionString))
        {
            connection.Open();
            using (var command = new NpgsqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        order.OrderId = reader.GetInt32(0);
                        order.ProductId = reader.GetInt32(1); 
                        order.Quantity = reader.GetInt32(2);
                        order.OrderDate = reader.GetDateTime(3);
                    }
                }
            }
        }
        return order;
    }
    
    public void DeleteOrder(int productId)
    {
        string query = $"DELETE \nFROM public.\"Orders\"\nUSING public.\"Products\"\nWHERE public.\"Orders\".\"ProductId\" = public.\"Products\".\"ProductId\"\n  and public.\"Products\".\"ProductId\" = {productId}";

        using (var connection = new NpgsqlConnection(database.connectionString))
        {
            connection.Open();
            using (var command = new NpgsqlCommand(query, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) deleted.");
            }
        }
    }
}