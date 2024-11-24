using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3HomeworkConsoleApp.Lecture3Homework
{
    class Lecture3HomeworkTask3
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

            if(int.TryParse(input, out numberOfOpenTabs))
            {
                numberOfOpenTabs = int.Parse(input);

                if (numberOfOpenTabs > 0 && numberOfOpenTabs <= 10)
                {
                    Console.WriteLine($"The number of tabs is: {numberOfOpenTabs}");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        

    }
}
