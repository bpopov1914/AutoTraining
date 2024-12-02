using L6Exercise.Utils;

namespace L6Exercise;

class Program
{
    static void Main(string[] args)
    {
        MainMenu mainMenu = new();
        Actions actions = new();
        mainMenu.PrintWelcomeMessage();
        mainMenu.PrintMainMenu();
        actions.SelectOption();
    }
}