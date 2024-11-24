namespace L3HomeworkConsoleApp;

class L3Homework
{
    static void Main(string[] args)
    {
        ////Task 1: Cinema Hall
        //var cinemaHall = new Lecture3HomeworkTask1();
        //cinemaHall.InputScreeningType();
        //cinemaHall.InputNumberOfRows();
        //cinemaHall.InputNumberOfColumns();
        //cinemaHall.CalculateTotalRevenue();
        
        ////Task 2: Fishing Trip
        //var fishingTrip = new Lecture3HomeworkTask2();
        //bool budgetInRange = fishingTrip.InputGroupBudget();
        ////Stop further execution if budget not in range
        //if (!budgetInRange)
        //{
        //    return;
        //}
        //bool isSeasonValid = fishingTrip.InputSeason();
        ////Stop further execution if season is not valid
        //if (!isSeasonValid)
        //{
        //    return;
        //}
        //bool isNumOfPeopleInRange = fishingTrip.InputNumOfFisherman();
        ////Stop further execution if number of fisherman not in range
        //if (!isNumOfPeopleInRange)
        //{
        //    return;
        //}
        //fishingTrip.DeterminePriceBasedOnSeason();
        //fishingTrip.CalculateFinalPrice();
        //fishingTrip.IsBudgetEnough();

        //Task 3: Salary Deduction
        var salaryDeduction = new Lecture3Homework.Lecture3HomeworkTask3();
        bool isNumOfTabsInRange = salaryDeduction.InputNumOfTabs();
        //Stop further execution if number of tabs not in range
        if (!isNumOfTabsInRange) 
        {
            return;
        }

    }
}