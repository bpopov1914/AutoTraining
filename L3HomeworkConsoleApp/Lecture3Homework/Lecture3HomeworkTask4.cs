namespace AutoTrainingConsoleApp.L3HomeworkConsoleApp.Lecture3Homework;

public class Lecture3HomeworkTask4
{
    private int stepsPerDayGoal = 10000;
    private int stepsPerDay = 0;
    private string userInput;

    public void EnterSteps()
    {
        Console.WriteLine("Task 4:");
        while (stepsPerDay < stepsPerDayGoal)
        {
            Console.WriteLine("Please enter the number of the steps that you took or \"Going home\" if you are done for the day: ");
            userInput = Console.ReadLine();
            bool stepsEntered = int.TryParse(userInput, out int steps);
            if (stepsEntered)
            {
                stepsPerDay += steps;
                Console.WriteLine($"You have made {stepsPerDay} steps so far.");
            }
            else if (!stepsEntered)
            {
                if(userInput == "Going home")
                {
                    Console.WriteLine("Please enter how many steps you took to reach home.");
                    userInput = Console.ReadLine();
                    stepsEntered = int.TryParse(userInput, out steps);
                    if (stepsEntered)
                    {
                        stepsPerDay += steps;
                        break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Please enter a valid input.");
                    return;
                }
            }
        }

        if (stepsPerDay >= stepsPerDayGoal)
        {
            Console.WriteLine("Goal reached! Good job!");
        }
        else
        {
            int differenceInSteps = stepsPerDayGoal - stepsPerDay;
            Console.WriteLine($"{differenceInSteps} more steps to reach goal.");
        }
        Console.WriteLine("-------------End of Task 4-------------");
    }
}