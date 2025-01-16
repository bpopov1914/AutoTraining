using Newtonsoft.Json.Linq;
using RestSharp;

namespace L16Exam.Utils;

public class Country
{
    public List<string> countries = new();

    public void LoadListOfCountries()
    {
        ApiUtil apiUtil = new ApiUtil();
        RestClient client = new RestClient();
        RestRequest request = new RestRequest();
        request.Resource = apiUtil.apiUrl;
        request.Method = Method.Get;
        RestResponse response = client.Execute(request);
        var deserializedResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<List<JObject>>(response.Content);
        
        foreach (var obj in deserializedResponse)
        {
            countries.Add(obj["name"]["common"].ToString());
        }
    }

    public bool IsCountryValid(string country)
    {
        if (countries.Contains(country))
        {
            Console.WriteLine("Country is valid");
            return true;
        }
        
        Console.WriteLine("Country is not present in the list of valid countries.");
        return false;
        
    }
    
}