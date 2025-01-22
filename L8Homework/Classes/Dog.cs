namespace L8Homework.Classes;

public class Dog : Animal
{
    public Dog()
    {
        
    }
    public Dog(string name, string favoriteFood)
    {
        Name = name;
        FavoriteFood = favoriteFood;
    }
    public void Bark()
    {
        Console.WriteLine("barking...");
    }
    public override string ExplainSelf()
    {
        return $"I am {Name} and my favorite food is {FavoriteFood}. DJAAF";
    }
}