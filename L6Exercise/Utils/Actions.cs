namespace L6Exercise.Utils;

public class Actions
{
    Students students = new Students();
    UserInput userInput = new UserInput();
    Subjects subjects = new Subjects();
    private int selectedOption;

    public void SelectOption()
    {
        //Add validations
        selectedOption = int.Parse(Console.ReadLine());
        SelectAction(selectedOption);
    }
    void SelectAction(int selectedOption)
    {
        switch (selectedOption)
        {
            case 1:
                //Add a new student
                string studentToAdd = userInput.InputStudentName();
                students.AddStudent(studentToAdd);
                break;
            case 2:
                //Remove a student
                string studentToRemove = userInput.InputStudentName();
                students.RemoveStudent(studentToRemove);
                break;
            case 3:
                //Assign student to subject
                string studentToUpdate = userInput.InputStudentName();
                string subject = userInput.InputSubject();
                bool isSubjectAllowed = subjects.CheckIfSubjectIsAllowed(subject);
                if (isSubjectAllowed)
                {
                    students.AssignStudentToSubject(studentToUpdate, subject);
                }
                else
                {
                    Console.WriteLine("Invalid subject");
                }
                break;
            case 4:
                //Add grades to subject
                string studentToUGrade = userInput.InputStudentName();
                string subjectToGrade = userInput.InputSubject();
                List<double> grades = userInput.InputGrade();
                students.AssignGradesToStudent(studentToUGrade, subjectToGrade, grades);
                break;
            case 5:
                //Display all students
                students.DisplayAllStudents();
                break;
            case 6:
                Console.WriteLine("Exiting the system. Goodbye!");
                break;
            default:
                Console.WriteLine("Please enter a valid option");
                break;
        }
    }
}