using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using System.Net.Http;

namespace FunctionAppHTTPClient
{
    public static class AzureFunctionWeatherApp
    {

        private static readonly HttpClient WeatherDataHttpClient = new HttpClient();

        [FunctionName("AzureFunctionWeatherApp")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req)
            {

            string apiKey = "hidden for GitHub";

            //so use "?cityname=" in the query string
            string cityName = req.Query["cityname"];

            HttpResponseMessage responseMessage = await GetCurrentWeatherData(cityName, apiKey);
            if (responseMessage.IsSuccessStatusCode)
                return new OkObjectResult(responseMessage.Content.ReadAsAsync(typeof(object)).Result);

            return new NotFoundResult();
            }

        private static async Task<HttpResponseMessage> GetCurrentWeatherData(string cityName, string apiKey)
        {
            return await WeatherDataHttpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}");
        }
    }
}