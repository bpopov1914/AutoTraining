using L16Exam.CountryModels;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace L16Exam.Utils;

public class Country
{
    public List<string> fullListOfCountries = new();
    public List<string> LoadListOfCountries()
    {
        ApiUtil apiUtil = new ApiUtil();
        RestClient client = new RestClient(apiUtil.apiUrl);
        RestRequest request = new RestRequest();
        request.Method = Method.Get;
        RestResponse response = client.Execute(request);
        var deserializedResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CountryModel>>(response.Content);
        
        List<string> countries = new();
        
        foreach (var countryModel in deserializedResponse)
        {
            countries.Add(countryModel.name.common);
        }

        foreach (var country in countries)
        {
            Console.Write($"{country}; ");
        }
        return countries;
    }

    public bool IsCountryValid(string countryToValidate, List<string> countries)
    {
        fullListOfCountries = countries;
        foreach (string country in fullListOfCountries)
        {
            bool isCountryValid = country.Equals(countryToValidate);
            if (isCountryValid)
            {
                Console.WriteLine("Country is valid");
                return true;
            }
        }
        Console.WriteLine("Country is not present in the list of valid countries.");
        return false;
    }
    
}