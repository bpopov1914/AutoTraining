namespace L11Homework.Models;

public class Order
{
    private int _orderId;
    private int _productId;
    private int _quantity;
    private DateTime _orderDate;

    public int OrderId
    {
        get { return _orderId;} 
        set { _orderId = value;}
    }
    public int ProductId
    {
        get { return _productId;} 
        set { _productId = value;}
    }
    public int Quantity
    {
        get { return _quantity;} 
        set { _quantity = value;}
    }
    public DateTime OrderDate
    {
        get { return _orderDate;} 
        set { _orderDate = value;}
    }
}