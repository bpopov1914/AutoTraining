namespace L9Homework.Classes;

public abstract class Animal
{
    public string Name { get; set; }
    public abstract void MakeSound();

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating!");
    }
}