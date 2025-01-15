using L11Homework.Interfaces;

namespace L11Homework.Models;

public class Product
{
    private int _productId;
    private string _name;
    private double _price;
    private int _stock;

    public int ProductId
    {
        get { return _productId;} 
        set { _productId = value;}
    }
    public string Name
    {
        get { return _name;} 
        set { _name = value;}
    }
    public double Price
    {
        get { return _price;} 
        set { _price = value;}
    }
    public int Stock
    {
        get { return _stock;} 
        set { _stock = value;}
    }
    
}