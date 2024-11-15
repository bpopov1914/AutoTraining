namespace AutoTrainingConsoleApp;

public class Lecture2HomeworkTask1
{
    //Task 1: Convert and Add Two Numbers
    
    //Variables initialization
    private static string firstNumInput = "";
    private static string secondNumInput = "";
    static int firstNum = 0;
    static int secondNum = 0;
    static int sum = 0;
    static bool firstNumCanBeParsed = false;
    static bool secondNumCanBeParsed = false;
    //Prompt the user to input numbers
    public static void InputNumbers()
    {
        //Prompt the user to input two numbers
        Console.WriteLine("Task 1: Hello, for this exercise, please enter two numbers.");
        Console.WriteLine("Please enter the first number:");
        firstNumInput = Console.ReadLine();
        Console.WriteLine("Please enter the second number:");
        secondNumInput = Console.ReadLine();
    }
    //Print the sum of the two numbers.
    public static void PrintSum()
    {
        //Check if input can be parsed to int
        firstNumCanBeParsed = int.TryParse(firstNumInput, out firstNum);
        Console.WriteLine("First number can be parsed: " + firstNumCanBeParsed);
        secondNumCanBeParsed = int.TryParse(secondNumInput, out secondNum);
        Console.WriteLine("Second number can be parsed: " + secondNumCanBeParsed);

        if (firstNumCanBeParsed && secondNumCanBeParsed)
        {
            //Parse the nums
            firstNum = int.Parse(firstNumInput);
            secondNum = int.Parse(secondNumInput);
            
            //Add the two nums
            sum = firstNum + secondNum;
            
            //Print the sum of the two numbers.
            Console.WriteLine("The sum of the two numbers is: " + sum);
        }
        else
        {
            Console.WriteLine("One or both of the two numbers is invalid.");
        }
        Console.WriteLine("-------------End of Task 1-------------");
    }
    
}