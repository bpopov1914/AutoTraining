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
        // {Subject name}-{grade} 
        //subject = Console.ReadLine();
        
        //while grade is a number in range 0-6
        grade = double.Parse(Console.ReadLine());
        grades.Add(grade);
        return grades;
    }
}