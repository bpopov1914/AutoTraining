namespace L6Exercise.Utils;

class Students
{
    private Dictionary<string, Dictionary<string, List<double>>> students = new();
    private Dictionary<string, List<double>> assignedSubjects = new();
    private List<double> grades = new();
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
            students.Add(studentToAdd, assignedSubjects);
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
                bool isSubjectAlreadyAssigned = assignedSubjects.ContainsKey(subject);
                if (!isSubjectAlreadyAssigned)
                {
                    assignedSubjects.Add(subject, grades);
                    students[studentToUpdate] = new Dictionary<string, List<double>>()
                    {
                        { subject, grades }
                    };
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
        Console.WriteLine("Please enter the name of the student you want to grade: ");
        string studentToGrade = userInput.InputStudentName();
        bool studentExists = students.ContainsKey(studentToGrade);
        
        if (studentExists)
        {
            Console.WriteLine("Please enter the subject you want to add grades to: ");
            string subjectToGrade = userInput.InputSubject();
            bool isSubjectAllowed = subjects.CheckIfSubjectIsAllowed(subjectToGrade);
            if (isSubjectAllowed)
            {
                bool isSubjectAssigned = students[studentToGrade].ContainsKey(subjectToGrade);
                if (isSubjectAssigned)
                {
                    //students[studentToUpdate].Add(subject, new List<int>());
                    grades = userInput.InputGrade();
                    //students[studentToGrade].s
                    Console.WriteLine($"Student {studentToGrade} was successfully enrolled in the.");
                }
                else
                {
                    //Console.WriteLine($"Student {studentToGrade} is not assigned to subject: {subject}");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid subject you want to assign: \"Math\", \"Biology\", \"History\", \"English\", \"Sport\", \"Physics\"");
            }
            
        }
        else
        {
            //Console.WriteLine($"Student {studentToUpdate} doesn't exist.");
        }
        //Console.WriteLine($"Student {studentToUGrade} has successfully been assigned a grade of {grades} for the {subjectToGrade} class.");
    }

    public void CalculateAverageGrade(Dictionary<string, Dictionary<string, List<int>>> students)
    {
        //Add logic to calculate the final grade
    }

    public void DisplayAllStudents()
    {
        //Add logic to display all students, their subjects and the average grade
        //CalculateAverageGrade(students);
        Console.WriteLine(students);
    }
    
}