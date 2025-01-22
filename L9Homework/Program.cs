using L9Homework.Classes;
using L9Homework.Classes.Task1;
using L9Homework.Classes.Task2;
using L9Homework.Classes.Task4;
using L9Homework.Classes.Task3;
using L9Homework.Interfaces;

namespace L9Homework;

class Program
{
    static void Main(string[] args)
    {
        //Task 1
        Console.WriteLine("------- Task 1 ----------");
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
        Console.WriteLine("------- Task 2 ----------");
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
        Console.WriteLine("------- Task 3 ----------");
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
        
        
        //Task 4
        Console.WriteLine("------- Task 4 ----------");
        Book book1 = new Book("The Witcher", "Andrzej Sapkowski");
        Book book2 = new Book("The Lord Of The Rings", "J.R.R. Tolkien");
        Magazine magazine1 = new Magazine("Top Gear", 101);
        Magazine magazine2 = new Magazine("Auto Build", 202);

        Library library = new Library();
        library.AddItem(book1);
        library.AddItem(book2);
        library.AddItem(magazine1);
        library.AddItem(magazine2);

        library.BorrowItem("Boris", book1, DateTime.Now.AddDays(7)); 
        library.BorrowItem("Boris", book2, DateTime.Now.AddDays(7)); 
        library.BorrowItem("Boris", magazine1, DateTime.Now.AddDays(7)); 
        library.BorrowItem("Boris", magazine2, DateTime.Now.AddDays(7)); 

        library.BorrowItem("Daniel", magazine2, DateTime.Now.AddDays(7));
        magazine2.ExtendDueDate(7);
        library.ShowLibraryStatus();

        library.ReturnItem("Boris", book1);
        library.BorrowItem("Boris", magazine2, DateTime.Now.AddDays(7)); 

        library.ShowLibraryStatus();
    }
}