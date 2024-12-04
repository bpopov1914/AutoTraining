namespace AutoTrainingConsoleApp.Lecture2Homework;

public class Lecture2HomeworkTask5
{
    //Task 5: Validate Age Input

    //Variables initialization
    static int age = 0;
    static string ageInput = "";
    static bool isAgeValid = false;

    public static void InputAge()
    {
        //Prompt the user to input age
        Console.WriteLine("Task 5: Please enter your age: ");
        ageInput = Console.ReadLine();
    }

    public static void ValidateAgeInput()
    {
        //Try to parse the age to see if it is a valid integer
        isAgeValid = int.TryParse(ageInput, out int age);
        if (!isAgeValid)
        {
            Console.WriteLine("Invalid age entered.");
        }
    }

    public static void PrintResult()
    {
        age = int.Parse(ageInput);
        if (age > 0 && age <= 120)
        {
            Console.WriteLine($"Your age is: {age}");
        }
        else
        {
            Console.WriteLine("Invalid age entered.");
        }
        Console.WriteLine("-------------End of Task 5-------------");
    }
}