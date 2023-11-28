using Newtonsoft.Json;

using weather.Models;

namespace weather.Services
{
    public static class ApiService
    {
        public static async Task<Root> GetWeather(double latitude, double longitude)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&lang=zh_tw&appid=5844881adf49ef5824c47c94f051aa1a", latitude, longitude));
            return JsonConvert.DeserializeObject<Root>(response);
        }
        public static async Task<Root> GetWeatherByCity(string city)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&lang=zh_tw&appid=5844881adf49ef5824c47c94f051aa1a",city));
            return JsonConvert.DeserializeObject<Root>(response);
        }

    }
}
