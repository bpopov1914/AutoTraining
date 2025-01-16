using L16Exam.Utils;

namespace L16Exam.Employees;

public class Employee
{
    private string _fullName;
    private string _country;
    private List<string> _departments;
    private double _salary;

    public Employee(string fullName, string country, double salary)
    {
        _fullName = fullName;
        _country = country;
        _salary = salary;
    }

    public string FullName
    {
        get{return _fullName;}
        set{_fullName = value;}
    }
    
    public string Country
    {
        get{return _country;}
        set{_country = value;}
    }

    public double Salary
    {
        get{return _salary;}
        set{_salary = value;}
    }

    public void AssignDepartments(List<string> departments)
    {
        foreach (var department in departments)
        {
            _departments.Add(department);
        }
    }
}