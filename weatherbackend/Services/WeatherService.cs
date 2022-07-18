using System;
using System.IO;
using RestSharp;
using Newtonsoft.Json;
using weatherbackend.Models;

namespace weatherbackend.Services;

public class WeatherService
{
    public WeatherModel.root? root;

    public void Main()
    {
        string API_KEY = "238d2ea9bbcc36ddb60ea4b143d8c391";
        string COUNTRY_CODE = "US";
        int ZIP_CODE = 62236;

        string MAIN_URL = $"https://api.openweathermap.org/data/2.5/weather?zip={ZIP_CODE},{COUNTRY_CODE}&appid={API_KEY}&units=imperial";

        RestRequest request = new RestRequest(MAIN_URL);
        RestClient client = new RestClient(MAIN_URL);

        if(request != null)
        {
            RestResponse response = client.ExecuteGetAsync(request).Result;

            if(response.IsSuccessful == false)
            {
                Console.WriteLine("ERROR : RESPONSE UNSUCESSFULL");
            }
            else
            {
                root = JsonConvert.DeserializeObject<WeatherModel.root>(response.Content.ToString());
            }
        }
    }
}
