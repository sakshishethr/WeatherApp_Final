using WeatherApp_Library.Models;

namespace WeatherApp_F.Services.Interfaces
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecastModel>> Find();
    }
}
