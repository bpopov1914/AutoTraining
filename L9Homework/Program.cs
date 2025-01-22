using L9Homework.Classes;

namespace L9Homework;

class Program
{
    static void Main(string[] args)
    {
        Animal cat = new Cat("Tom");
        Animal dog = new Dog("Spike");
        Animal catTwo = new Cat("Tom 2");
        Animal dogTwo = new Dog("Spike 2");
        Animal catThree = new Cat("Tom 3");
        Animal dogThree = new Dog("Spike 3");
        
        List<Animal> animals = new List<Animal>();
        animals.Add(cat);
        animals.Add(dog);
        animals.Add(catTwo);
        animals.Add(dogTwo);
        animals.Add(catThree);
        animals.Add(dogThree);

        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Eat();
        }
        
    }
}