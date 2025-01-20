namespace L16Exam.Utils;

public class Actions
{
    EmployeeManagement employeeManagement = new();
    MainMenu mainMenu = new();
    private int selectedOption;
    private bool isSaveDataSelected;
    
    public void SelectOption(Country country)
    {
        while (!isSaveDataSelected)
        {
            mainMenu.PrintMainMenu();
            bool optionSelectedIsValid = int.TryParse(Console.ReadLine(), out int selectedOption);
            if (optionSelectedIsValid)
            {
                SelectAction(selectedOption, country);
            }
            else
            {
                Console.WriteLine("Please enter a valid number between 1 and 5.");
            }
        }
    }
    void SelectAction(int selectedOption, Country country)
    {
        switch (selectedOption)
        {
            case 1:
                //Add a new employee
                employeeManagement.AddEmployees(country);
                break;
            case 2:
                //Remove an employee
                employeeManagement.RemoveEmployee();
                break;
            case 3:
                //Assign departments to employee
                employeeManagement.AssignDepartments();
                break;
            case 4:
                //Update employee salary
                employeeManagement.UpdateSalaries();
                break;
            case 5:
                isSaveDataSelected = true;
                employeeManagement.SaveData();
                break;
            default:
                Console.WriteLine("Please enter a valid option.");
                break;
        }
    }
}