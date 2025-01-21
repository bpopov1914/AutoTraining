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
    }
}