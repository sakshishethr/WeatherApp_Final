using System;
using NUnit.Framework;
using WeatherApp_Library.Models;

namespace Weather_UnitTests
{
    [TestFixture]
    public class WeatherForecastModelTests
    {
        [Test]
        public void WeatherForecastModel_PropertiesShouldBeSetCorrectly()
        {
            // Arrange
            DateTime date = DateTime.Now;
            int temperatureC = 20;
            int temperatureF = 68;
            string summary = "Sunny day";

            // Act
            WeatherForecastModel weatherForecast = new WeatherForecastModel
            {
                Date = date,
                TemperatureC = temperatureC,
                TemperatureF = temperatureF,
                Summary = summary
            };

            // Assert
            Assert.AreEqual(date, weatherForecast.Date);
            Assert.AreEqual(temperatureC, weatherForecast.TemperatureC);
            Assert.AreEqual(temperatureF, weatherForecast.TemperatureF);
            Assert.AreEqual(summary, weatherForecast.Summary);
        }
    }
}
