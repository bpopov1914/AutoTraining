namespace L14Homework.ModelsT2;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Company Employer { get; set; }
    public List<string> Skills { get; set; }
 
}