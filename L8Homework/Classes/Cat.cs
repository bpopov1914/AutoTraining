namespace L8Homework.Classes;

public class Cat : Animal
{
    public Cat()
    {
        
    }

    public Cat(string name, string favoriteFood)
    {
        Name = name;
        FavoriteFood = favoriteFood;
    }
    public void Meow()
    {
        Console.WriteLine("meowing...");
    }

    public override string ExplainSelf()
    {
        return $"I am {Name} and my favorite food is {FavoriteFood}. MEEOW";
    }
}