using L16Exam.Utils;


namespace L16Exam;

class Program
{
    static void Main(string[] args)
    { 
        Country country = new Country();
        Actions actions = new Actions();
        
        country.fullListOfCountries = country.LoadListOfCountries();
        actions.SelectOption(country);
        
    }
}