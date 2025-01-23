using L14Homework.JsonModel;
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
        JsonModel.JsonModel json = JsonConvert.DeserializeObject<JsonModel.JsonModel>(jsonString);
        List<Department> departments = json.departments.ToList();
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
}