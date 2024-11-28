namespace L6Exercise.Utils;
class MainMenu
{
    private Dictionary<int, string> menuOptions = new Dictionary<int, string>()
    {
        {1, "1. Add a new student"},
        {2, "2. Remove a student"},
        {3, "3. Assign student to subject"},
        {4, "4. Update a student's grades"},
        {5, "5. Display all students"},
        {6, "6. Exit"}
        
    };

    public void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Student Data Management System!");
    }
    
    public void PrintMainMenu()
    {
        Console.WriteLine("Choose an option:");
        foreach (var option in menuOptions)
        {
            Console.WriteLine(option.Value);
        }
    }
}