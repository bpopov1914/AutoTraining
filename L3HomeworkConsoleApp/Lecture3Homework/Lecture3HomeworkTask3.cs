using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3HomeworkConsoleApp.Lecture3Homework
{
    public class Lecture3HomeworkTask3
    {
        //Task 3: Salary Deduction

        //Variables initialization
        int numberOfOpenTabs;
        double salary;
        string website;
        string facebook = "Facebook";
        string instagram = "Instagram";
        string reddit = "Reddit";
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
                    Console.WriteLine($"Your salary is: {numberOfOpenTabs} BGN");
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
        

    }
}
