namespace L3HomeworkConsoleApp.Lecture3Homework
{
    public class Lecture3HomeworkTask3
    {
        //Task 3: Salary Deduction

        //Variables initialization
        int numberOfOpenTabs;
        double salary;
        string website;
        List<string> openTabs = new List<string>();
        double fbFine = 150;
        double instaFine = 100;
        double redFine = 50;

        //Input number of open tabs
        public bool InputNumOfTabs()
        {
            Console.WriteLine("Task 3: Please enter the number of tabs. Must be a valid number between 1 and 10.");
            string input = Console.ReadLine();

            //Check if input is valid
            if(int.TryParse(input, out numberOfOpenTabs))
            {
                //Parse input
                numberOfOpenTabs = int.Parse(input);

                //Check if input is in range
                if (numberOfOpenTabs > 0 && numberOfOpenTabs <= 10)
                {
                    Console.WriteLine($"The number of tabs is: {numberOfOpenTabs}");
                    return true;
                }
                else
                {
                    Console.WriteLine("The number of tabs is not between 1 and 10.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                return false;
            }
        }

        //Input salary
        public bool InputSalary()
        {
            Console.WriteLine("Please enter your salary. Must be a valid number between 700 and 1500.");
            string input = Console.ReadLine();

            //Check if input is valid
            if (double.TryParse(input, out salary))
            {
                //Parse input
                salary = double.Parse(input);

                //Check if input is in range
                if (salary >= 700 && salary <= 1500)
                {
                    Console.WriteLine($"Your salary is: {salary} BGN");
                    return true;
                }
                else
                {
                    Console.WriteLine("The salary is not between 700 and 1500.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                return false;
            }
        }

        //Check opened websites
        public void CheckWebsites()
        {
            //Prompt the user to enter all opened websites
            Console.WriteLine("Please enter the names of the opened websites:");
            for (int i = 1; i <= numberOfOpenTabs; i++) 
            {
                website = Console.ReadLine();
                openTabs.Add(website);
                Console.WriteLine($"\'{website}\' was added to the list of open tabs.");
            }

            //Determine fines
            foreach (string website in openTabs) 
            {
                //Check if open website is prohibited
                switch (website)
                {
                    case "Facebook":
                        salary = salary - fbFine;
                        Console.WriteLine($"Facebook is opened. Your salary is now {salary} BGN");
                        break;
                    case "Instagram":
                        salary = salary - instaFine;
                        Console.WriteLine($"Instagram is opened. Your salary is now {salary} BGN");
                        break;
                    case "Reddit":
                        salary = salary - redFine;
                        Console.WriteLine($"Reddit is opened. Your salary is now {salary} BGN");
                        break;
                    default:
                        Console.WriteLine($"No fine applied. Your salary is {salary} BGN");
                        break;

                }
                //Check if salary is above 0 on each iteration
                if(salary <= 0)
                {
                    Console.WriteLine($"You have lost your salary.");
                    Console.WriteLine("-------------End of Task 3-------------");
                    break;
                }
            }

            //Print the remaining salary as an integer
            if(salary > 0)
            {
                Console.WriteLine($"Your remaining salary is {(int)salary} BGN");
                Console.WriteLine("-------------End of Task 3-------------");
            }

        }
        

    }
}
