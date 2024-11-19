namespace L3HomeworkConsoleApp;

public class Lecture3HomeworkTask1
{ 
    //Task 1: Cinema Hall
    
    //Variables initialization
    int numOfRows;
    int numOfColumns;
    int totalNumOfSeats;
    string screeningInput = "";
    string premiereScreening = "Premiere";
    string normalScreening = "Normal";
    string discountScreening = "Discount";
    double premierePrice = 12.00;
    double normalPrice = 7.50;
    double discountPrice = 5.00;
    double actualPrice;
    double totalRevenue;
    
    //Prompt the user to input screening type
    public void InputScreeningType()
    {
        Console.WriteLine("Please enter the type of the screening. Use one of the following options: Premiere, Normal, Discount: ");
        screeningInput = Console.ReadLine();

        switch (screeningInput)
        {
            case "Premiere": 
                actualPrice = premierePrice; 
                Console.WriteLine($"The price of the Premiere screening is: {actualPrice.ToString("0.00")}BGN");
                break;
            case "Normal": 
                actualPrice = normalPrice;
                Console.WriteLine($"The price of the Normal screening is: {actualPrice.ToString("0.00")}BGN");
                break;
            case "Discount": 
                actualPrice = discountPrice;
                Console.WriteLine($"The price of the Discount screening is: {actualPrice.ToString("0.00")}BGN");
                break;
            default: Console.WriteLine("Please enter a valid type of the screening (Premiere, Normal, Discount).");
                break;
        }
    }
    //Prompt the user to input the number of rows
    public void InputNumberOfRows()
    {
        Console.WriteLine("Please enter the number of rows: "); 
        string input = Console.ReadLine();
        bool canParse = int.TryParse(input, out numOfRows);
        if (canParse)
        {
            numOfRows = int.Parse(input);
            Console.WriteLine($"The number of rows is: {numOfRows}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number of rows.");
        }
    }
    //Prompt the user to input the number of columns
    public void InputNumberOfColumns()
    {
        Console.WriteLine("Please enter the number of columns: ");
        string input = Console.ReadLine();
        bool canParse = int.TryParse(input, out numOfColumns);
        if (canParse)
        {
            numOfColumns = int.Parse(input);
            Console.WriteLine($"The number of columns is: {numOfColumns}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number of columns.");
        }
    }

    public void CalculateTotalRevenue()
    {
        //Calculate the total number of seats
        totalNumOfSeats = numOfRows * numOfColumns;
        
        //Calculate the total revenue
        totalRevenue = totalNumOfSeats * actualPrice;
        
        //Print the result
        Console.WriteLine($"The total revenue is: {totalRevenue.ToString("0.00")}BGN");
    }
}