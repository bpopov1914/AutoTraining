namespace L3HomeworkConsoleApp;

class L3Homework
{
    static void Main(string[] args)
    {
        //Task 1: Cinema Hall
        var cinemaHall = new Lecture3HomeworkTask1();
        cinemaHall.InputScreeningType();
        cinemaHall.InputNumberOfRows();
        cinemaHall.InputNumberOfColumns();
        cinemaHall.CalculateTotalRevenue();
        
        //Task 2: Fishing Trip
        var fishingTrip = new Lecture3HomeworkTask2();
        fishingTrip.InputGroupBudget();
        fishingTrip.InputSeason();
        fishingTrip.InputNumOfFisherman();
        fishingTrip.DeterminePriceBasedOnSeason();
        fishingTrip.CalculateFinalPrice();
        fishingTrip.IsBudgetEnough();
    }
}