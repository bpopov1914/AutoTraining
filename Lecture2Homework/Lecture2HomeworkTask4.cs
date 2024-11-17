namespace AutoTrainingConsoleApp;

public class Lecture2HomeworkTask4
{
    //Task 4: Calculate the Area of a Circle
    
    //Variables initialization
    static double pi = Math.PI;
    static string radiusInput = "";
    static double radius = 0;
    static bool radiusCanBeParsed = false;

    public static void InputRadius()
    {
        //Prompt the user to input a radius
        Console.WriteLine("Task 4: Please enter the radius of the circle: ");
        radiusInput = Console.ReadLine();
    }

    public static bool RadiusCanBeParsed()
    {
        //Check if input can be parsed to double
        radiusCanBeParsed = double.TryParse(radiusInput, out radius);
        return radiusCanBeParsed;
    }

    public static void ParseRadius()
    {
        //Parse the input to double
        if (radiusCanBeParsed)
        {
            radius = double.Parse(radiusInput);
            Console.WriteLine($"The radius of the circle is: {radius}");
        }
        else
        {
            Console.WriteLine("The radius is not valid. Please try again.");
        }
        Console.WriteLine("-------------End of Task 4-------------");
    }
}