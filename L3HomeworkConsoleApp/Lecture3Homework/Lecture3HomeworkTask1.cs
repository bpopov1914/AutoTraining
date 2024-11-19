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
    
    //Prompt the user to input screening type
    public void InputScreeningType()
    {
        Console.WriteLine("Please enter the type of the screening. Use one of the following options: Premiere, Normal, Discount: ");
        screeningInput = Console.ReadLine();

        switch (screeningInput)
        {
            case "Premiere": 
                actualPrice = premierePrice; 
                Console.WriteLine($"The price of the Premiere screening is: {actualPrice}");
                break;
            case "Normal": 
                actualPrice = normalPrice;
                Console.WriteLine($"The price of the Normal screening is: {actualPrice}");
                break;
            case "Discount": 
                actualPrice = discountPrice;
                Console.WriteLine($"The price of the Discount screening is: {actualPrice}");
                break;
            default: Console.WriteLine("Please enter a valid type of the screening (Premiere, Normal, Discount).");
                break;
        }
    }
    //Prompt the user to input the number of rows
    public void InputNumberOfRows()
    {
        Console.WriteLine("Please enter the number of rows: "); 
        numOfRows = int.Parse(Console.ReadLine());
    }
    //Prompt the user to input the number of columns
    public void InputNumberOfColumns()
    {
        Console.WriteLine("Please enter the number of columns: ");
        numOfColumns = int.Parse(Console.ReadLine());
    }
}