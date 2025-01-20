using L16Exam.Utils;

namespace L16Exam.Employees;

public class Employee
{
    private string _fullName;
    private string _country;
    private List<string> _departments = new();
    private decimal _salary;
   
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

    public decimal Salary
    {
        get{return _salary;}
        set{_salary = value;}
    }

    public List<string> Departments
    {
        get{return _departments;}
        set{_departments = value;}
    }
    
}