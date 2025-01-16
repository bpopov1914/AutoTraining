using L16Exam.Utils;


namespace L16Exam;

class Program
{
    static void Main(string[] args)
    { 
        Country country = new Country();
        MainMenu mainMenu = new MainMenu();
        
        country.LoadListOfCountries();
        mainMenu.PrintMainMenu();

        /*
        This was for testing if I am recording the countries from the API properly 
        foreach (var countryName in country.countries)
        {
            Console.WriteLine(countryName);
        }*/
    }
}