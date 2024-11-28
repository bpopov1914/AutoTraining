namespace L6Exercise.Utils;

public class Actions
{
    MainMenu mainMenu = new MainMenu();
    Students students = new Students();
    UserInput userInput = new UserInput();

    void PerformSelectedAction(int selectedOption)
    {
        switch (selectedOption)
        {
            case 1:
                string studentToAdd = userInput.InputStudentName();
                students.AddStudent(studentToAdd);
                break;
            case 2:
                string studentToRemove = userInput.InputStudentName();
                students.RemoveStudent(studentToRemove);
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            default:
                break;
        }
    }
}