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
}