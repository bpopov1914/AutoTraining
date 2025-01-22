namespace L9Homework.Classes.Task1;

public class Cat : Animal
{
    public Cat(string name)
    {
        Name = name;
    }
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}