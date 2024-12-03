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
                    assignedSubjects.Add(subject, new List<double>());
                    students[studentToUpdate] = new Dictionary<string, List<double>>();
                    students[studentToUpdate][subject] = new List<double>(grades);
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
                    grades = userInput.InputGrade();
                    assignedSubjects[subjectToGrade].AddRange(grades);
                    Console.WriteLine($"Student {studentToGrade}: Subject: {subjectToGrade}: Grades: " + string.Join(", ", grades));
                }
                else
                {
                    Console.WriteLine($"Student {studentToGrade} is not assigned to subject: {subjectToGrade}");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid subject you want to assign: \"Math\", \"Biology\", \"History\", \"English\", \"Sport\", \"Physics\"");
            }
            
        }
        else
        {
            Console.WriteLine($"Student {studentToGrade} doesn't exist.");
        }
        
    }

    public double CalculateAverageGrade(Dictionary<string, Dictionary<string, List<double>>> students)
    {
        double averageGrade = 0;
        foreach (var student in students)
        {
            double totalGrades = 0;
            int totalSubjects = 0;

            foreach (var subject in student.Value)
            {
                List<double> grades = subject.Value;
                totalGrades = totalGrades + grades.Sum();
                totalSubjects = totalSubjects + grades.Count;
            }

            if (totalSubjects > 0)
            {
                averageGrade = totalGrades / totalSubjects;
            }
            else
            {
                averageGrade = 0;
            }
        }

        return averageGrade;
    }

    public void DisplayAllStudents()
    {
        double averageGrade = CalculateAverageGrade(students);

        foreach (var student in students)
        {
            string subjects = string.Join(", ", student.Value);
            Console.WriteLine($"{student.Key}, Subjects: {subjects} \nAverage Grade: {averageGrade:F2}");
        }
    }
    
}