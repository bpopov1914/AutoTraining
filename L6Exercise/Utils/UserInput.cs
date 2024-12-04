namespace L6Exercise.Utils;
class UserInput
{   
    string studentNameInput; //{StudentName} - for add, delete and update student’s grade operations.
    string subject; //{StudentName}-{Subject} - for assigning student to subject.
    double grade; // {Subject name}-{grade} - to update a student's grade. The grade is double within range [2…6].
    List<double> grades = new();
    

    public string InputStudentName()
    {
        studentNameInput = Console.ReadLine();
        return studentNameInput;
    }

    public string InputSubject()
    {
        //{StudentName}-{Subject}
        subject = Console.ReadLine();
        return subject;
    }

    public List<double> InputGrade()
    {
        Console.WriteLine("Please enter the number of grades you want to add: ");
        string numberOfGradesInput = Console.ReadLine();
        bool numOfGradesCanBeParsed = int.TryParse(numberOfGradesInput, out int numOfGrades);
        
        if (numOfGradesCanBeParsed)
        {
            int counter = 0;
            while (counter < numOfGrades)
            {
                Console.WriteLine("Please enter grade. Must be in the range [2-6]: ");
                string gradeInput = Console.ReadLine();
                bool canGradeBeParsed = double.TryParse(gradeInput, out double grade);
                if (canGradeBeParsed && (grade >= 2 && grade <= 6))
                {
                    grades.Add(grade);
                    counter++;
                }
                else
                {
                    Console.WriteLine("Please enter a valid grade. Must be in the range [2-6].");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid grade. Must be in the range [2-6].");
        }
        
        return grades;
    }
}