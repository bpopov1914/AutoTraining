namespace L9Homework.Classes;

public class Clothing : Product
{
    public Clothing(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public override void GetDiscountedPrice()
    {
        decimal discount = Price * 0.2m;
        decimal discountedPrice = Price - discount;
        Console.WriteLine($"Price after 20% discount is: {Math.Round(discountedPrice,2)}");
    }
}