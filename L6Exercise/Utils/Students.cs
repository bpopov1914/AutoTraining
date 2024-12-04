namespace L6Exercise.Utils;

class Students
{
    private Dictionary<string, Dictionary<string, List<double>>> students = new();
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
            Dictionary<string, List<double>> assignedSubjects = new();
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
                bool isSubjectAlreadyAssigned = students[studentToUpdate].ContainsKey(subject);
                if (!isSubjectAlreadyAssigned)
                {
                    List<double> grades = new();
                    students[studentToUpdate].Add(subject, grades);
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
                    List<double> grades = userInput.InputGrade();
                    AddGradesToSubjects(students[studentToGrade], grades, subjectToGrade);
                    Console.WriteLine($"Student \"{studentToGrade}\": Subject \"{subjectToGrade}\"");
                    foreach (var grade in students[studentToGrade].Values)
                    {
                        Console.Write($"{grade} ");
                    }
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

    public double CalculateAverageGrade(Dictionary<string, List<double>> subjects)
    {
        double averageGrade = 0;
        double totalGradesSum = 0;
        int numOfSubjects = subjects.Count;
        int numOfGrades = 0;

        foreach (var subject in subjects)
        {
            List<double> grades = subject.Value;
            var totalGradesSumPerSubject = grades.Sum();
            totalGradesSum = totalGradesSum + totalGradesSumPerSubject;
            numOfGrades = numOfGrades + grades.Count();
        }

        if (numOfSubjects > 0)
        {
            averageGrade = totalGradesSum / numOfGrades;
        }
        else
        {
            averageGrade = 0;
        }
        
        return averageGrade;
    }

    public void DisplayAllStudents()
    {
        foreach (var student in students)
        {
            string subjects = string.Join(", ", student.Value.Keys);
            double averageGrade = CalculateAverageGrade(student.Value);

            Console.WriteLine($"{student.Key}, Subjects: {subjects} \nAverage Grade: {averageGrade:F2}");
        }
    }
    
     static void AddGradesToSubjects(
         Dictionary<string, List<double>> subjects, 
         List<double> grades, 
         string subjectName)
     {
         foreach (var subject in subjects)
         {
             if (subject.Key == subjectName)
             {
                 subject.Value.AddRange(grades);
             }
         }
     }
    
}