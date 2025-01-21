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
        
        //Task 5: Sort an Array in Ascending Order
        Console.WriteLine("------- Task 5 ----------");
        string[] inputT5 = Console.ReadLine().Split();
        
        if (inputT5.Length == 0 || Array.Exists(inputT5, s => string.IsNullOrWhiteSpace(s)))
        {
            Console.WriteLine("Input contains only whitespace or invalid values.");
            return;
        }

        int[] numbersT5;
        try
        {
            numbersT5 = Array.ConvertAll(inputT5, int.Parse);
        }
        catch (FormatException)
        {
            Console.WriteLine("Input contains invalid numbers.");
            return;
        }
        
        int[] sortedNumbersT5 = methods.SortArray(numbersT5);
        string arrayString = string.Empty;
        foreach (int num in sortedNumbersT5)
        {
            arrayString = arrayString + num + ", ";
        }
        
        Console.WriteLine($"[ {arrayString.Trim().TrimEnd(',')} ]");
        
        Console.WriteLine("------- End of Task 5 ----------");
        
        //Task 6: Swap Two Numbers
        Console.WriteLine("------- Task 6 ----------");
        Console.WriteLine("Please input first number: ");
        bool canParseFirstNum = int.TryParse(Console.ReadLine(), out int firstNumber);
        Console.WriteLine("Please input second number: ");
        bool canParseSecondNum = int.TryParse(Console.ReadLine(), out int secondNumber);
        if (canParseFirstNum && canParseSecondNum)
        {
            Console.WriteLine($"First number: {firstNumber}, Second number: {secondNumber}");
            methods.SwapNumbers(ref firstNumber, ref secondNumber);
            Console.WriteLine($"First number: {firstNumber}, Second number: {secondNumber}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
        Console.WriteLine("------- End of Task 6 ----------");
        
        //Task 7: Update Array Elements
        Console.WriteLine("------- Task 7 ----------");
        Console.WriteLine("Please input multiple numbers: ");
        string[] inputT7 = Console.ReadLine().Split();
        Console.WriteLine("Please input factor: ");
        bool canParseFactor = int.TryParse(Console.ReadLine(), out int factor);
        if (inputT7.Length == 0 || Array.Exists(inputT7, s => string.IsNullOrWhiteSpace(s)))
        {
            Console.WriteLine("Input contains only whitespace or invalid values.");
            return;
        }

        int[] numbersT7;
        try
        {
            numbersT7 = Array.ConvertAll(inputT7, int.Parse);
            Console.WriteLine("Original array: ");
            foreach (int element in numbersT7)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        catch (FormatException)
        {
            Console.WriteLine("Input contains invalid numbers.");
            return;
        }

        if (canParseFactor)
        {
            methods.MultiplyArrayElements(ref numbersT7, factor);
            Console.WriteLine("Array after multiplication: ");
            foreach (int element in numbersT7)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Please enter a valid number for the factor.");
        }
        Console.WriteLine("------- End of Task 7 ----------");
        
        //Task 8: Divide Two Numbers
        Console.WriteLine("------- Task 8 ----------");
        Console.WriteLine("Please input first number: ");
        bool canParseNum1= int.TryParse(Console.ReadLine(), out int num1);
        Console.WriteLine("Please input second number: ");
        bool canParseNum2= int.TryParse(Console.ReadLine(), out int num2);
        int quotient;
        int remainder;
        if (canParseNum1 && canParseNum2)
        {
            if (methods.DivideNumbers(num1, num2, out quotient, out remainder))
            {
                Console.WriteLine($"Quotient: {quotient}");
                Console.WriteLine($"Remainder: {remainder}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
        
        Console.WriteLine("------- End of Task 8 ----------");
        
        //Task 9: Parse String to Number
        Console.WriteLine("------- Task 9 ----------");
        Console.WriteLine("Please input number: ");
        string input1 = Console.ReadLine();
        int result1 = methods.ConvertStringToInt(input1);
        Console.WriteLine($"Input: {input1}, Converted: {result1}");
        Console.WriteLine("------- End of Task 9 ----------");
    }
}