namespace L6Exercise.Utils;

class Students
{
    private Dictionary<string, Dictionary<string, List<int>>> students = new();
    private Dictionary<string, List<int>> assignedSubjects = new();
    UserInput userInput = new();
    Subjects subjects = new();
    public void AddStudent()
    {
        Console.WriteLine("Please enter the name of the student you want to add: ");
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
        Console.WriteLine("Please enter the name of the student you want to assign to a subject: ");
        string studentToUpdate = userInput.InputStudentName();
        bool studentExists = students.ContainsKey(studentToUpdate);
        
        if (studentExists)
        {
            Console.WriteLine("Please enter the subject you want to assign the student to: ");
            string subject = userInput.InputSubject();
            bool isSubjectAllowed = subjects.CheckIfSubjectIsAllowed(subject);
            if (isSubjectAllowed)
            {
                bool isSubjectAlreadyAssigned = students[studentToUpdate].ContainsKey(subject);
                if (!isSubjectAlreadyAssigned)
                {
                    students[studentToUpdate].Add(subject, new List<int>());
                    Console.WriteLine($"Student {studentToUpdate} was successfully enrolled in the {subject} class.");
                }
                else
                {
                    Console.WriteLine($"Student {studentToUpdate} is already assigned to subject: {subject}");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid subject you want to assign: \"Math\", \"Biology\", \"History\", \"English\", \"Sport\", \"Physics\"");
            }
            
        }
        else
        {
            Console.WriteLine($"Student {studentToUpdate} doesn't exist.");
        }
        
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