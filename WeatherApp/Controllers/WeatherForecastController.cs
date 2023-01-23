using System;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Interfaces;

namespace WeatherApp.Controllers
{
	[ApiController]
	public class WeatherForecastController : ControllerBase
	{
		private readonly IWeatherClient _weatherClient;

        public WeatherForecastController(IWeatherClient weatherClient)
        {
            _weatherClient = weatherClient;
        }

        [HttpGet("weather/{city}")]
		public async Task<IActionResult> Forecast(string city)
		{
			var weather = await _weatherClient.GetCurrentWeatherForCity(city);
			return weather is not null ? Ok(weather) : NotFound();
		}
	}
}

