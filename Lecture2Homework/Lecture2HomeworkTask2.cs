namespace AutoTrainingConsoleApp;

public class Lecture2HomeworkTask2
{
    //Task 2: Format a Full Name
    
    //Variables initialization
    static string firstName = "";
    static string lastName = "";
    static string fullName = "";

    public static void InputNames()
    {
        //Prompt the user to input first name and last name
        Console.WriteLine("Task 2: Hello, for this exercise, please enter your first name and last name.");
        Console.WriteLine("Please enter your first name:");
        firstName = Console.ReadLine();
        Console.WriteLine("Please enter your last name:");
        lastName = Console.ReadLine();
    }

    public static void ConcatAndPrintNames()
    {
        //Concatenate the first and last names in the format "Last Name, First Name."
        fullName = $"{lastName}, {firstName}";
        Console.WriteLine($"Your full name is: {fullName}");
        Console.WriteLine("-------------End of Task 2-------------");
    }
}