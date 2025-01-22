using L9Homework.Classes;
using L9Homework.Interfaces;

namespace L9Homework;

class Program
{
    static void Main(string[] args)
    {
        //Task 1
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
        
        
        //Task 2
        Assignment assignment = new Assignment(6,5.50);
        Assignment assignmentTwo = new Assignment(6,4.80);
        Exam exam = new Exam(6,5.50);
        Exam examTwo = new Exam(6,4.80);

        List<IGradeCalculator> calculators = new List<IGradeCalculator>();
        calculators.Add(assignment);
        calculators.Add(assignmentTwo);
        calculators.Add(exam);
        calculators.Add(examTwo);

        foreach (var calc in calculators)
        { 
            double result = calc.CalculateGrade();
            Console.WriteLine($"Result: {Math.Round(result,2)}%"); 
        }
        
        //Task 3
        Product product1 = new Electronics("Phone", 899.99m);
        Product product2 = new Electronics("Tablet", 499.99m);
        Product product3 = new Clothing("Jacket", 59.99m);
        Product product4 = new Clothing("Shirt", 29.99m);
        
        List<Product> products = new List<Product>();
        products.Add(product1);
        products.Add(product2);
        products.Add(product3);
        products.Add(product4);

        foreach (var product in products)
        {
            product.DisplayInfo();
            product.GetDiscountedPrice();
        }
    }
}