using L6Exercise.Utils;

namespace L6Exercise;

class Program
{
    static void Main(string[] args)
    {
        MainMenu mainMenu = new MainMenu();
        
        //Print welcome message and options
        mainMenu.PrintWelcomeMessage();
        mainMenu.PrintMainMenu();
        
    }
}