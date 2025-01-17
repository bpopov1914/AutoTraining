using L16Exam.Employees;
using Newtonsoft.Json;


namespace L16Exam.Utils;

public class EmployeeManagement
{
    UserInput userInput = new();
    List<Employee> employees = new();
    public void AddEmployees(Country country)
    {
        Employee employee = new Employee();
        string fullName = userInput.InputFullName();
        string countryToAdd = userInput.InputCountry();
        decimal salary = userInput.InputSalary();
        bool isCountryValid = country.IsCountryValid(countryToAdd, country.fullListOfCountries);
        bool doesEmployeeExist = DoesEmployeeExist(fullName);
        bool salaryIsNonNegative = salary > 0;
        if (isCountryValid && !doesEmployeeExist && salaryIsNonNegative)
        {
            employee.FullName = fullName;
            employee.Country = countryToAdd;
            employee.Salary = salary;
            employees.Add(employee);
            Console.WriteLine($"Employee added: {employee.FullName}, {employee.Country}, {employee.Salary}");
        }
        else if (isCountryValid && doesEmployeeExist)
        {
            Console.WriteLine("Employee already exists!");
        }
        else if (isCountryValid && !doesEmployeeExist && !salaryIsNonNegative)
        {
            Console.WriteLine("Salary cannot be negative!");
        }
        else
        {
            Console.WriteLine("Employee was not added. Please try again.");
        }
    }

    public void RemoveEmployee()
    {
        string employeeToRemove = userInput.InputFullName();
        bool doesEmployeeExist = DoesEmployeeExist(employeeToRemove);
        
        for (int i = 0; i < employees.Count; i++)
        {
            if (doesEmployeeExist && employees[i].FullName == employeeToRemove)
            {
                employees.RemoveAt(i); 
                i--;
                Console.WriteLine($"Employee removed: {employeeToRemove}");
            }
        }
    }

    public void AssignDepartments()
    {
        string employeeName = userInput.InputFullName();
        bool employeeExists = DoesEmployeeExist(employeeName);
        
        foreach (Employee employee in employees)
        {
            if (employeeExists && employee.FullName == employeeName)
            {
                List<string> departmentsToAdd = userInput.InputDepartments();
                foreach (var depToAdd in departmentsToAdd)
                {
                    employee.Departments.Add(depToAdd);
                }
                string departmentsString = "";
                foreach (var department in departmentsToAdd)
                {
                    departmentsString = departmentsString + department + "; ";
                }
                Console.WriteLine($"{employee.FullName} was assigned the following departments: {departmentsString}");
            }
        }
    }

    public void  UpdateSalaries()
    {
        string employeeName = userInput.InputFullName();
        bool employeeExists = DoesEmployeeExist(employeeName);
        foreach (Employee employee in employees)
        {
            if (employeeExists)
            {
                decimal newSalary = userInput.InputSalary();
                if (newSalary != employee.Salary && newSalary > 0)
                {
                    employee.Salary = newSalary;
                    Console.WriteLine($"Employee salary updated: {employee.FullName}, {employee.Salary}"); 
                }
                else if(newSalary <= 0)
                {
                    Console.WriteLine("Salary must be greater than 0.");
                }
                else
                {
                    Console.WriteLine("Salary was not updated. Please try again.");
                }
            }
        }
    }

    public void SaveData()
    {
        string filePath ="savedData.json";
        
        using (StreamWriter writer = new StreamWriter(filePath))
        using (JsonTextWriter jsonWriter = new JsonTextWriter(writer))
        {
            jsonWriter.Formatting = Formatting.Indented;
            jsonWriter.WriteStartArray();
            
            foreach (Employee employee in employees)
            {
                JsonSerializer.CreateDefault().Serialize(jsonWriter, employee);
            }

            jsonWriter.WriteEndArray();
        }

    }

    private bool DoesEmployeeExist(string fullName)
    {
        foreach (var employee in employees)
        {
            if (employee.FullName.Equals(fullName))
            {
                return true;
            }
            
        }
        Console.WriteLine("Employee was not found. Please try again.");
        return false;
    }

}