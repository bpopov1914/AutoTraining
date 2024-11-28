using L6Exercise.Utils;

namespace L6Exercise;

class Program
{
    static MainMenu mainMenu = new MainMenu();
    static void Main(string[] args)
    {
        mainMenu.PrintWelcomeMessage();
        mainMenu.PrintMainMenu();
        mainMenu.SelectOption();
        
    }
}