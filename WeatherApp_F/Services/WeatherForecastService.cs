using WeatherApp_Library.Models;
using WeatherApp_F.Helpers;
using WeatherApp_F.Services.Interfaces;

namespace WeatherApp_F.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/find";

        public WeatherForecastService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<WeatherForecastModel>> Find()
        {
            var response = await _client.GetAsync(BasePath);

            return await response.ReadContentAsync<List<WeatherForecastModel>>();
        }
    }
}
