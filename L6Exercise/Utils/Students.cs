namespace L6Exercise.Utils;

class Students
{
    private Dictionary<string, Dictionary<string, List<int>>> students = new Dictionary<string, Dictionary<string, List<int>>>();
    MainMenu mainMenu = new MainMenu();
    public void AddStudent(string studentName)
    {
        //Add check if user already exists
        students.Add(studentName, new Dictionary<string, List<int>>());
        Console.WriteLine($"Student {studentName} added successfully!");
        mainMenu.PrintMainMenu();
    }

    public void RemoveStudent(string studentName)
    {
        //Add check if user exists
        students.Remove(studentName);
        Console.WriteLine($"Student {studentName} removed successfully!");
        mainMenu.PrintMainMenu();
    }

    public void AssignStudentToSubject(string studentName, string subject)
    {
        //Add assignment logic
        Console.WriteLine($"Student {studentName} has successfully enrolled in the {subject} class.");
        mainMenu.PrintMainMenu();
    }

    public void AssignGradesToStudent(string studentName, string subject, List<double> grades)
    {
        //Add assignment logic
        Console.WriteLine($"Student {studentName} has successfully been assigned a grade of {grades} for the {subject} class.");
        mainMenu.PrintMainMenu();
    }

    public void CalculateAverageGrade(Dictionary<string, Dictionary<string, List<int>>> students)
    {
        //Add logic to calculate the final grade
        mainMenu.PrintMainMenu();
    }

    public void DisplayAllStudents()
    {
        //Add logic to display all students, their subjects and the average grade
        Console.WriteLine(students);
        mainMenu.PrintMainMenu();
    }
    
}