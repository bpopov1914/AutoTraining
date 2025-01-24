using L14Homework.JsonModel;
using L14Homework.ModelsT2;
using Newtonsoft.Json;
namespace L14Homework;

public class JsonTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ParseAndExtractData()
    {
        string jsonString = "{\"departments\":[{\"name\":\"Engineering\",\"employees\":" +
                            "[{\"name\":\"Alice\",\"age\":30,\"skills\":[\"C#\",\"SQL\"]}," +
                            "{\"name\":\"Bob\",\"age\":35,\"skills\":[\"Java\",\"AWS\"]}]}," +
                            "{\"name\":\"HR\",\"employees\":[{\"name\":\"Charlie\",\"age\":28,\"skills\":" +
                            "[\"Recruitment\",\"Communication\"]},{\"name\":\"Diana\",\"age\":32,\"skills\":" +
                            "[\"Onboarding\",\"Training\"]}]}]}";
        JsonModelT1 json = JsonConvert.DeserializeObject<JsonModelT1>(jsonString);
        List<DepartmentT1> departments = json.departments.ToList();
        List<string> engineeringEmployees = new List<string>();
        List<string> hrEmployees = new List<string>();
        List<string> allSkills = new List<string>();
        
        foreach (var department in departments)
        {
            if (department.name == "Engineering")
            {
                for (int i = 0; i < department.employees.Count; i++)
                {
                    engineeringEmployees.Add(department.employees[i].name);
                    foreach(var skill in department.employees[i].skills)
                    {
                        allSkills.Add(skill);
                    }
                }
            }
            if (department.name == "HR")
            {
                for (int i = 0; i < department.employees.Count; i++)
                {
                    hrEmployees.Add(department.employees[i].name);
                    foreach(var skill in department.employees[i].skills)
                    {
                        allSkills.Add(skill);
                    }
                }
            }
        }
        Console.WriteLine("All data: ");
        foreach (var department in departments)
        {
            for (int i = 0; i < department.employees.Count; i++)
            {
                Console.WriteLine(
                    $"Department: {department.name}, Employee: {department.employees[i].name}, Age: {department.employees[i].age}, " +
                    $"Skills: {department.employees[i].skills[0]}, {department.employees[i].skills[1]}");
            }
        }
        
        Console.WriteLine("\nEngineering employees:");
        foreach (var engineeringEmployee in engineeringEmployees)
        {
            Console.WriteLine($"Name: {engineeringEmployee}");
        }
        
        Console.WriteLine($"\nAll skills: {string.Join(", ", allSkills)}");

        Console.WriteLine("\nEmployees over 30:");
        foreach (var department in departments)
        {
            for (int i = 0; i < department.employees.Count; i++)
            {
                if (department.employees[i].age > 30)
                {
                    Console.WriteLine($"Department: {department.name}, Name: {department.employees[i].name}");
                }
            }
        }
        

    }

    [Test]
    public void ComplexObjectSerializationAndDeserialization()
    {
        Address address1 = new Address();
        address1.City = "New York";
        address1.Street = "Some New York Street";
        Address address2 = new Address();
        address2.City = "Los Angeles";
        address2.Street = "Some Los Angeles Street";
        Address address3 = new Address();
        address3.City = "Minneapolis";
        address3.Street = "Some Minneapolis Street";
        
        Company company1 = new Company();
        company1.Name = "Company 1";
        company1.Location = address1;
        Company company2 = new Company();
        company2.Name = "Company 2";
        company2.Location = address2;
        Company company3 = new Company();
        company3.Name = "Company 3";
        company3.Location = address3;
        
        Employee employee1 = new Employee();
        employee1.Id = 1;
        employee1.Name = "Employee 1";
        employee1.Employer = company1;
        employee1.Skills = new List<string>(){"C#", "Java"};
        Employee employee2 = new Employee();
        employee2.Id = 2;
        employee2.Name = "Employee 2";
        employee2.Employer = company2;
        employee2.Skills = new List<string>(){"SQL", "Python"};
        Employee employee3 = new Employee();
        employee3.Id = 3;
        employee3.Name = "Employee 3";
        employee3.Employer = company3;
        employee3.Skills = new List<string>(){"AWS", "Azure"};
        Employee employee4 = new Employee();
        employee4.Id = 4;
        employee4.Name = "Employee 4";
        employee4.Employer = company3;
        employee4.Skills = new List<string>(){"C++", "PHP"};
        
        List<Employee> employees = new List<Employee>();
        employees.Add(employee1);
        employees.Add(employee2);
        employees.Add(employee3);
        employees.Add(employee4);
        
        string jsonString = JsonConvert.SerializeObject(employees, Formatting.Indented);
        
        List<Employee> newEmployees = JsonConvert.DeserializeObject<List<Employee>>(jsonString);

        foreach (var employee in newEmployees)
        {
            Console.WriteLine($"Name: {employee.Name}, Company: {employee.Employer.Name}, Location: {employee.Employer.Location.City}, {employee.Employer.Location.Street}, Skills: {string.Join(", ", employee.Skills)}");
        }
        
        IEnumerable<Employee> employeeQuery =
            from employee in newEmployees
            where employee.Employer.Location.City == "Minneapolis"
            select employee;

        Console.WriteLine("\nEmployees from Minneapolis: ");
        foreach (var employee in employeeQuery)
        {
            Console.WriteLine($"Name: {employee.Name}, City: {employee.Employer.Location.City}");
        }

    }
}