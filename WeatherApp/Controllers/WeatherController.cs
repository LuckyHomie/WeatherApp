using System;
using Microsoft.AspNetCore.Mvc;

namespace WeatherApp.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class WeatherController : ControllerBase
	{
		[HttpGet("{cityName}")]
		public async Task<IActionResult> GetWeatherDataByCityNameAsync([FromRoute] string cityName)
		{
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://api.openweathermap.org/data/2.5/forecast?q={cityName}&appid=3b0d16dab44859d1ecb30e52b478dd48&units=metric");
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return Ok(responseBody);
		}
	}
}

