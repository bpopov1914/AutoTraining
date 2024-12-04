namespace L3HomeworkConsoleApp.Lecture3Homework;

public class Lecture3HomeworkTask6
{
    private static int n;
    private int l;
    private string userInput;
    static Random rand  = new();
    private int randIndx;
    private int symbolOne;
    private int symbolTwo;
    private char symbolThree;
    private char symbolFour;
    private int symbolFive;

    public void GeneratePassword()
    {
        Console.WriteLine("Task 6: Please enter two numbers. Each should be between 0 and 9: ");
        userInput = Console.ReadLine();
        bool isNInt = int.TryParse(userInput, out n);
        userInput = Console.ReadLine();
        bool isLInt = int.TryParse(userInput, out l);
        if (!isNInt || !isLInt)
        {
         Console.WriteLine("Please enter valid integers.");   
        }
        else if ((n >= 1 && n <= 9) && (l >= 1 && l <= 9))
        {
            symbolOne = rand.Next(1, n);
            symbolTwo = rand.Next(1, n);
            randIndx = rand.Next(0, l);
            symbolThree = (char)('a' + randIndx);
            randIndx = rand.Next(0, l);
            symbolFour = (char)('a' + randIndx);
            
            do
            {
                randIndx = rand.Next(1, n);
            }while(randIndx <= symbolOne || randIndx <= symbolTwo);

            symbolFive = randIndx;
            List<string> symbols = new List<string> { symbolOne.ToString(), symbolTwo.ToString(), symbolThree.ToString(), symbolFour.ToString(), symbolFive.ToString() };
            PrintAllPasswords(symbols);
        }
        else
        {
            Console.WriteLine("Integers are out of range.");
        }

    }

    private void PrintAllPasswords(List<string> symbols)
    {
        Console.WriteLine($"The list of all possible passwords using the following symbols:" +
                          $" {symbolOne}, {symbolTwo}, {symbolThree}, {symbolFour}, {symbolFive}");
        // Generate and print all permutations
        var permutations = GetPermutations(symbols, symbols.Count);
        foreach (var perm in permutations)
        {
            Console.WriteLine(string.Join("", perm));
        }
    }
    
    // To be honest, I used some help from ChatGPT for the method below
    // Method to generate permutations
    public static List<List<string>> GetPermutations(List<string> list, int length)
    {
        List<List<string>> result = new List<List<string>>();

        // Base case: if length is 1, return the list itself
        if (length == 1)
        {
            foreach (var item in list)
            {
                result.Add(new List<string> { item });
            }
            return result;
        }

        // Recursively get the permutations for the smaller list
        foreach (var item in list)
        {
            // Create a sublist without the current item
            var remaining = new List<string>(list);
            remaining.Remove(item);

            // Generate permutations for the remaining symbols
            var subPermutations = GetPermutations(remaining, length - 1);

            // Add the current item to the beginning of each permutation from the sublist
            foreach (var perm in subPermutations)
            {
                var newPerm = new List<string> { item };
                newPerm.AddRange(perm);
                result.Add(newPerm);
            }
        }

        return result;
    }
    
}