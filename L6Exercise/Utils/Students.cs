namespace L6Exercise.Utils;

class Students
{
    private Dictionary<string, Dictionary<string, List<int>>> students = new();
    UserInput userInput = new();
    public void AddStudent()
    {
        Console.WriteLine("Please enter the students name: ");
        string studentToAdd = userInput.InputStudentName();
        bool doesStudentExist = students.ContainsKey(studentToAdd);
        if (doesStudentExist)
        {
            Console.WriteLine($"Student {studentToAdd} already exists.");
        }
        else
        {
            students.Add(studentToAdd, new Dictionary<string, List<int>>());
            Console.WriteLine($"Student {studentToAdd} added successfully!");
        }
    }

    public void RemoveStudent()
    {
        Console.WriteLine("Please enter the name of the student you want to remove: ");
        string studentToRemove = userInput.InputStudentName();
        bool doesStudentExist = students.ContainsKey(studentToRemove);
        if (!doesStudentExist)
        {
            Console.WriteLine($"Student {studentToRemove} doesn't exist.");
        }
        else
        {
            students.Remove(studentToRemove);
            Console.WriteLine($"Student {studentToRemove} removed successfully!");
        }
    }

    public void AssignStudentToSubject()
    {
        string studentToUpdate = userInput.InputStudentName();
        string subject = userInput.InputSubject();
        //Add assignment logic
        Console.WriteLine($"Student {studentToUpdate} has successfully enrolled in the {subject} class.");
    }

    public void AssignGradesToStudent()
    {
        string studentToUGrade = userInput.InputStudentName();
        string subjectToGrade = userInput.InputSubject();
        List<double> grades = userInput.InputGrade();
        //Add assignment logic
        Console.WriteLine($"Student {studentToUGrade} has successfully been assigned a grade of {grades} for the {subjectToGrade} class.");
    }

    public void CalculateAverageGrade(Dictionary<string, Dictionary<string, List<int>>> students)
    {
        //Add logic to calculate the final grade
    }

    public void DisplayAllStudents()
    {
        //Add logic to display all students, their subjects and the average grade
        CalculateAverageGrade(students);
        Console.WriteLine(students);
    }
    
}