namespace L6Exercise.Utils;

public class Actions
{
    Students students = new();
    MainMenu mainMenu = new();
    private int selectedOption;
    private bool isExitSelected;
    
    public void SelectOption()
    {
        mainMenu.PrintWelcomeMessage();
        while (!isExitSelected)
        {
            mainMenu.PrintMainMenu();
            //Add validations
            selectedOption = int.Parse(Console.ReadLine());
            SelectAction(selectedOption);
        }
    }
    void SelectAction(int selectedOption)
    {
        switch (selectedOption)
        {
            case 1:
                //Add a new student
                students.AddStudent();
                break;
            case 2:
                //Remove a student
                students.RemoveStudent();
                break;
            case 3:
                //Assign student to subject
                students.AssignStudentToSubject();
                break;
            case 4:
                //Add grades to subject
                students.AssignGradesToStudent();
                break;
            case 5:
                //Display all students
                students.DisplayAllStudents();
                break;
            case 6:
                isExitSelected = true;
                Console.WriteLine("Exiting the system. Goodbye!");
                break;
            default:
                Console.WriteLine("Please enter a valid option");
                break;
        }
    }
}