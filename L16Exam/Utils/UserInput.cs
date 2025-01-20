namespace L16Exam.Utils;

public class UserInput
{
    public string fullName;
    public string country;
    public decimal salary;
    
    public string InputFullName()
    {
        Console.WriteLine("Please enter full name: ");
        fullName = Console.ReadLine();
        return fullName;
    }

    public string InputCountry()
    {
        Console.WriteLine("Enter country: ");
        country = Console.ReadLine();
        return country;
    }

    public decimal InputSalary()
    {
        Console.WriteLine("Enter salary: ");
        bool isValidInput = decimal.TryParse(Console.ReadLine(), out decimal salaryInput);
        if (isValidInput)
        {
            if (salaryInput > 0)
            {
                salary = salaryInput;
            }
            else
            {
                Console.WriteLine("Salary must be greater than 0.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid salary value.");
        }
        return salary;
    }

    public List<string> InputDepartments()
    {
        List<string> departments = new List<string>();
        Console.WriteLine("Enter the number of departments you want to add: ");
        int.TryParse(Console.ReadLine(), out int numOfDepartments);
        for (int i = 0; i < numOfDepartments; i++)
        {
            Console.WriteLine("Please enter department: ");
            string department = Console.ReadLine();
            departments.Add(department);
        }
        return departments;
    }
}