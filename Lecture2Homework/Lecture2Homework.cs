namespace AutoTrainingConsoleApp;

public class Lecture2Homework
{
    //Task 1: Convert and Add Two Numbers
    
    //Variables initialization
    private static string firstNumInput = "";
    private static string secondNumInput = "";
    static int firstNum = 0;
    static int secondNum = 0;
    
    //Method to print the sum of the two numbers.
    public static void PrintTheSumOfTwoNumbers()
    {
        //Prompt the user to input two numbers
        Console.WriteLine("Hello, for this exercise, please enter two numbers.");
        Console.WriteLine("Please enter the first number:");
        firstNumInput = Console.ReadLine();
        Console.WriteLine("Please enter the second number:");
        secondNumInput = Console.ReadLine();
        
        //Check if input can be parsed to int
        bool firstNumCanBeParsed = int.TryParse(firstNumInput, out firstNum);
        Console.WriteLine(firstNumCanBeParsed);
        bool secondNumCanBeParsed = int.TryParse(secondNumInput, out secondNum);
        Console.WriteLine(secondNumCanBeParsed);

        if (firstNumCanBeParsed && secondNumCanBeParsed)
        {
            //Print the sum of the two numbers.
            Console.WriteLine("The sum of the two numbers is: " + firstNum + secondNum);
        }
    }
    
}