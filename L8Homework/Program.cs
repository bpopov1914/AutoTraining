using L8Homework.Classes;

namespace L8Homework;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();
        
        Puppy puppy = new Puppy();
        puppy.Eat();
        puppy.Bark();
        puppy.Weep();
        
        Cat cat = new Cat();
        cat.Eat();
        cat.Meow();
        
        MathOperations mo = new MathOperations();
        Console.WriteLine(mo.Add(2, 3));
        Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
        Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));

        Animal cat2 = new Cat("Maria", "Whiskas");
        Animal dog2 = new Dog("Rex", "Meat");
        Console.WriteLine(cat2.ExplainSelf());
        Console.WriteLine(dog2.ExplainSelf());
    }
}