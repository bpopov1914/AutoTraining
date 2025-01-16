namespace L16Exam.Utils;

public class MainMenu
{
    private List<string> options = new()
    {
        "1. Add employees",
        "2. Remove employee",
        "3. Assign departments",
        "4. Update salaries",
        "5. Save data"
    };

    public void PrintMainMenu()
    {
        foreach (var option in options)
        {
            Console.WriteLine(option);
        }
    }
}