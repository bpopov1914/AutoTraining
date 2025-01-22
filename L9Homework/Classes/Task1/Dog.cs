using L9Homework.Classes;

namespace L9Homework.Classes.Task1;

public class Dog : Animal
{
    public Dog(string name)
    {
        Name = name;
    }
    public override void MakeSound()
    {
        Console.WriteLine("Bark!");
    }
}