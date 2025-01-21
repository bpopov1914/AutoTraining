namespace L5Homework.Utils;

public class Methods
{
    //Task 1
    public int FindLargestNumber(int[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("The array is empty.");
        }

        int largest = array[0];

        foreach (int num in array)
        {
            if (num > largest && num > 0)
            {
                largest = num;
            }
        }
        
        return largest;
    }
    
    //Task 2
    public string ReverseString(string originalString)
    {
        string reverseString = string.Empty;
        for (int i = originalString.Length - 1; i >= 0; i--)
        {
            reverseString += originalString[i];
        }

        return reverseString;
    }
    
    //Task 3
    public void GenerateFibonacciSequence(int number)
    {
        int[] fibonacciSequence = new int[0];
        int nextNumInSequence = 0;
        int index = 0;
        do
        {
            Array.Resize(ref fibonacciSequence, fibonacciSequence.Length + 1);
            fibonacciSequence[index] = nextNumInSequence;
            if (index == 0)
            {
                nextNumInSequence = fibonacciSequence[index] + 1;
                index++;
            }
            else
            {
                nextNumInSequence = fibonacciSequence[index] + fibonacciSequence[index-1];
                index++;
            }
        }while(fibonacciSequence.Length < number);

        string numbersSequence = string.Empty;
        foreach (int num in fibonacciSequence)
        {
            numbersSequence = numbersSequence + num + ", ";
        }
        
        Console.WriteLine($"[ {numbersSequence.Trim().TrimEnd(',')} ]");
    }

    //Task 4
    public bool PrimeNumber(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number == 2)
        {
            return true;
        }

        if (number % 2 == 0)
        {
            return false;
        }

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
            {
                return false; 
            }
        }

        return true;
    }
    
    //Task 5
    public int[] SortArray(int[] array)
    {
        Array.Sort(array);
        return array;
    }
    
    //Task 6

    public void SwapNumbers(ref int firstNumber, ref int secondNumber)
    {
        int temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;
    }
}