namespace L3HomeworkConsoleApp;

public class Lecture3HomeworkTask2
{
    //Task 2: Fishing Trip
    
    //Variables initialization
    int groupBudget;
    string season;
    int numOfFisherman;
    double springPrice = 3000.00;
    double summerPrice = 4200.00;
    double autumnPrice = 4200.00;
    double winterPrice = 2600.00;
    
    //Prompt the user to input group budget an integer in the range [1…8000]
    public void InputGroupBudget()
    {
        Console.WriteLine("Enter group budget: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out groupBudget))
        {
            groupBudget = int.Parse(input);
            if (groupBudget >= 1 && groupBudget <= 8000)
            {
                Console.WriteLine($"You entered group budget: {groupBudget} BGN");
            }
            else
            {
                Console.WriteLine("Your budget must be between 1 and 8000");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number input.");
        }
    }

}