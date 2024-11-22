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
            default:
                Console.WriteLine("Please enter a valid season.");
                break;
        }
    }

    public void CalculateFinalPrice()
    {
        double discount;

        //Assign discount based on group size
        if (numOfFisherman <= 6)
        {
            //If group is up to 6 people, apply 10% discount
            discount = priceBeforeDiscounts * 0.10;
            Console.WriteLine($"The discount is: {discount}");
            //Calculate final price
            finalPrice = priceBeforeDiscounts - discount;
            Console.WriteLine($"The final price is: {finalPrice}");
        }
        else if (numOfFisherman > 6 && numOfFisherman <= 11)
        {
            //If group is between 7 and 11 people, apply 15% discount
            discount = priceBeforeDiscounts * 0.15;
            Console.WriteLine($"The discount is: {discount}");
            //Calculate final price
            finalPrice = priceBeforeDiscounts - discount;
            Console.WriteLine($"The final price is: {finalPrice}");
        }
        else
        {
            //If group is 12 people or more, apply 25% discount
            discount = priceBeforeDiscounts * 0.25;
            Console.WriteLine($"The discount is: {discount}");
            //Calculate final price
            finalPrice = priceBeforeDiscounts - discount;
            Console.WriteLine($"The final price is: {finalPrice}");
        }
        
        //Check if additional 5% discount should be applied
        if (numOfFisherman % 2 == 0 && season != "Autumn")
        {
            finalPrice = finalPrice * 0.5;
            Console.WriteLine($"An additional 5% is applied. The final price is: {finalPrice}");
        }
        else
        {
            Console.WriteLine($"No additional discount applied.");
        }
    }

    public void IsBudgetEnough()
    {
        if (groupBudget >= finalPrice)
        {
            Console.WriteLine($"Congratulations, you have rented a boat successfully for {finalPrice} BGN");
        }
        else
        {
            Console.WriteLine("Oops, it seems you don't have enough money to rent the boat.");
        }
        Console.WriteLine("-------------End of Task 2-------------");
    }
}