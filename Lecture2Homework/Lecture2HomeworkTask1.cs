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
    
    //Method to print the sum of the two numbers.
    public static void PrintTheSumOfTwoNumbers()
    {
        //Prompt the user to input two numbers
        Console.WriteLine("Hello, for the Task 1 exercise, please enter two numbers.");
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
    }
    
}