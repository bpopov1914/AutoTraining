namespace L9Homework.Classes;

public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}");
    }
    
    public abstract void GetDiscountedPrice();
}