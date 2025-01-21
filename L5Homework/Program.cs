using L5Homework.Utils;

namespace L5Homework;

class Program
{
    static void Main(string[] args)
    {
        Methods methods = new();
        
        //Task 1: Find the Largest Number in an Array
        Console.WriteLine("------- Task 1 ----------");
        string[] input = Console.ReadLine().Split();
        
        if (input.Length == 0 || Array.Exists(input, s => string.IsNullOrWhiteSpace(s)))
        {
            Console.WriteLine("Input contains only whitespace or invalid values.");
            return;
        }

        int[] numbers;
        try
        {
            numbers = Array.ConvertAll(input, int.Parse);
        }
        catch (FormatException)
        {
            Console.WriteLine("Input contains invalid numbers.");
            return;
        }
        
        int largestNumber = methods.FindLargestNumber(numbers);
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine("------- End of Task 1 ----------");
        
        //Task 2: Reverse a String
        Console.WriteLine("------- Task 2 ----------");
        string originalString = Console.ReadLine();
        string reverseString = methods.ReverseString(originalString);
        Console.WriteLine($"Reverse String is: {reverseString} ");
        Console.WriteLine("------- End of Task 2 ----------");
        
        //Task 3: Generate Fibonacci Sequence
        Console.WriteLine("------- Task 3 ----------");
        Console.WriteLine("Please enter a number: ");
        bool canBeParsed = int.TryParse(Console.ReadLine(), out int number);
        if (canBeParsed)
        {
            methods.GenerateFibonacciSequence(number);
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
        
        Console.WriteLine("------- End of Task 3 ----------");
        
        //Task 4: Check for Prime Numbers
        Console.WriteLine("------- Task 4 ----------");
        bool canParse = int.TryParse(Console.ReadLine(), out int numberInput);
        bool isNumberPrime;
        if (canParse)
        {
            isNumberPrime = methods.PrimeNumber(numberInput);
            Console.WriteLine($"{isNumberPrime}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
        Console.WriteLine("------- End of Task 4 ----------");
    }
}