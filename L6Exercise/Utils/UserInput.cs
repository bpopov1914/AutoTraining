namespace L6Exercise.Utils;
class UserInput
{ 
    private string studentNameInput; //{StudentName} - for add, delete and update student’s grade operations.

    private string subject; //{StudentName}-{Subject} - for assigning student to subject.
    private double grade; // {Subject name}-{grade} - to update a student's grade. The grade is double within range [2…6].
    

    public void InputStudentName()
    {
        studentNameInput = Console.ReadLine();
    }

    public void InputStudentAndSubject()
    {
        //{StudentName}-{Subject}
        studentNameInput = Console.ReadLine();
        subject = Console.ReadLine();
    }

    public void InputSubjectAndGrade()
    {
        // {Subject name}-{grade} 
        subject = Console.ReadLine();
        grade = double.Parse(Console.ReadLine());
    }
}