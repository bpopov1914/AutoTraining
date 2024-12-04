using AutoTrainingConsoleApp.L3HomeworkConsoleApp.Lecture3Homework;
using L3HomeworkConsoleApp.Lecture3Homework;

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
        bool budgetInRange = fishingTrip.InputGroupBudget();
        if (!budgetInRange)
        {
            //Stop further execution if budget not in range
            return;
        }
        bool isSeasonValid = fishingTrip.InputSeason();
        if (!isSeasonValid)
        {
            //Stop further execution if season is not valid
            return;
        }
        bool isNumOfPeopleInRange = fishingTrip.InputNumOfFisherman();
        if (!isNumOfPeopleInRange)
        {
            //Stop further execution if number of fisherman not in range
            return;
        }
        fishingTrip.DeterminePriceBasedOnSeason();
        fishingTrip.CalculateFinalPrice();
        fishingTrip.IsBudgetEnough();

        //Task 3: Salary Deduction
        var salaryDeduction = new Lecture3Homework.Lecture3HomeworkTask3();
        bool isNumOfTabsInRange = salaryDeduction.InputNumOfTabs();
        if (!isNumOfTabsInRange) 
        {
            //Stop further execution if number of tabs not in range
            return;
        }
        bool isSalaryInRange = salaryDeduction.InputSalary();
        if (!isSalaryInRange)
        {
            //Stop further execution if salary not in range
            return;
        }
        salaryDeduction.CheckWebsites();
        
        //Task 4: Steps to reach goal
        var stepsToReachGoal = new Lecture3HomeworkTask4();
        stepsToReachGoal.EnterSteps();
        
        //Task5: Birthday Cake
        var cakePieces = new Lecture3HomeworkTask5();
        cakePieces.TakeCakePieces();
        
        //Task6: Password Generator
        var passGenerator = new Lecture3HomeworkTask6();
        passGenerator.GeneratePassword();
    }
}