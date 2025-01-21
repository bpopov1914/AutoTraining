namespace L4Homework;

class Program
{
    static void Main(string[] args)
    {
        //Task 1: Common elements
        
        string[] arrayOne = { "Hey", "hello", "test", "2", "4"};
        string[] arrayTwo = { "10","test", "hey", "4", "hello", "no" };

        for (int i = 0; i < arrayOne.Length; i++)
        {
            for (int j = 0; j < arrayTwo.Length; j++)
            {
                if (arrayOne[i] == arrayTwo[j])
                {
                    Console.Write($"{arrayOne[i]} ");
                }
            }
        }
    }
}