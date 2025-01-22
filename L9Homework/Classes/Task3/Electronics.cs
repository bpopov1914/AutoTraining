namespace L9Homework.Classes.Task3;

public class Electronics : Product
{
    public Electronics(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public override void GetDiscountedPrice()
    {
        decimal discount = Price * 0.1m;
        decimal discountedPrice = Price - discount;
        Console.WriteLine($"Price after 10% discount is: {Math.Round(discountedPrice,2)}");
    }
}