namespace L16Exam.Utils;

public class UserInput
{
    public string fullName;
    public string country;
    public decimal salary;
    
    //I'll add validations for all inputs 
    
    public string InputFullName()
    {
        fullName = Console.ReadLine();
        return fullName;
    }

    public string InputCountry()
    {
        country = Console.ReadLine();
        return country;
    }

    public decimal InputSalary()
    {
        salary = decimal.Parse(Console.ReadLine());
        return salary;
    }
}