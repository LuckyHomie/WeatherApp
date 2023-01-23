using System;
using WeatherApp.Models;

namespace WeatherApp.Interfaces
{
    public interface IWeatherClient
    {
        public Task<OpenWeatherResponse?> GetCurrentWeatherForCity(string city);
    }
}

