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
}