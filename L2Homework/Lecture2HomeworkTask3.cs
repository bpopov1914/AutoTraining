namespace AutoTrainingConsoleApp.Lecture2Homework;

public class Lecture2HomeworkTask3
{
    //Task 3: Extract and Modify Substring

    //Variables initialization
    static string longString =
        "Hello, my name is Boris and in this task I'll extract a substring and convert it to upper case.";
    static string shortString = "";

    //Extract substring and convert to upper case
    public static void PrintSubstring()
    {
        //Extract name as substring and convert it to upper case
        shortString = longString.Substring(18, 5).ToUpper();
        //Print the substering
        Console.WriteLine($"Task 3: The extracted substring is: {shortString}");
        Console.WriteLine("-------------End of Task 3-------------");
    }
}