namespace L16Exam.Utils;

public class MainMenu
{
    private Dictionary<int, string> options = new()
    {
        {1,"1. Add employees"},
        {2,"2. Remove employee"},
        {3,"3. Assign departments"},
        {4,"4. Update salaries"},
        {5,"5. Save data"}
    };

    public void PrintMainMenu()
    {
        Console.WriteLine("\nChoose an option:");
        foreach (var option in options)
        {
            Console.WriteLine(option.Value);
        }
    }
}