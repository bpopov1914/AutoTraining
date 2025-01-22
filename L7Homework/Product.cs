namespace L7Homework;

public class Product
{
    private string _name;
    private decimal _price;
    private int _quantity;

    public Product()
    {
        _name = "Default name";
        _price = 5;
        _quantity = 1;
    }
    public Product(string name, decimal price, int quantity)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public string Name
    {
        get{return _name;}
        set{_name = value;}
    }

    public decimal Price
    {
        get{return _price;}
        set{_price = value;}
    }

    public int Quantity
    {
        get{return _quantity;}
        set{_quantity = value;}
    }

    public decimal CalculateTotalCost()
    {
        return _price * _quantity;
    }
}