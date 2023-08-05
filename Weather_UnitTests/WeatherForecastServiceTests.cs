using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using WeatherApp_Library.Models;
using WeatherApp_F.Helpers;
using WeatherApp_F.Services.Interfaces;
using WeatherApp_F.Services;

namespace Weather_UnitTests
{
    [TestFixture]
    public class WeatherForecastServiceTests
    {
        private Mock<HttpClient> _mockHttpClient;
        private WeatherForecastService _weatherForecastService;

        [SetUp]
        public void SetUp()
        {
            _mockHttpClient = new Mock<HttpClient>();
            _weatherForecastService = new WeatherForecastService(_mockHttpClient.Object);
        }
    }

}