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
    double priceBeforeDiscounts;
    double finalPrice;
    
    //Prompt the user to input group budget an integer in the range [1…8000]
    public void InputGroupBudget()
    {
        //Prompt the user to input group budget
        Console.WriteLine("Task 2: Enter group budget: ");
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

    public void InputSeason()
    {
        //Prompt the user to input the season
        Console.WriteLine("Please enter season: ");
        season = Console.ReadLine();
        if (season == "Winter" || season == "Summer" || season == "Autumn" || season == "Spring")
        {
            Console.WriteLine($"The selected season is: {season}");
        }
        else
        {
            Console.WriteLine("Please enter a valid season.");
        }
    }

    public void InputNumOfFisherman()
    {
        //Prompt the user to input the number of people in the group
        Console.WriteLine("Please enter the number of people in the group: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out numOfFisherman))
        {
            numOfFisherman = int.Parse(input);
            if (numOfFisherman >= 4 && numOfFisherman <= 18)
            {
                Console.WriteLine($"You are a group of {numOfFisherman} fisherman.");
            }
            else
            {
                Console.WriteLine("Your group must be between 4 and 18 fisherman");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number input.");
        }
    }

    public void DeterminePriceBasedOnSeason()
    {
        //Determine the price based on the season
        switch (season)
        {
            case "Winter":
                priceBeforeDiscounts = winterPrice;
                break;
            case "Summer":
                priceBeforeDiscounts = summerPrice;
                break;
            case "Autumn":
                priceBeforeDiscounts = autumnPrice;
                break;
            case "Spring":
                priceBeforeDiscounts = springPrice;
                break;
            
        }
    }
}