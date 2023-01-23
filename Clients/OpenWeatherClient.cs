using System;
using WeatherApp.Models;
using WeatherApp.Interfaces;

namespace WeatherApp.Clients
{
	public class OpenWeatherClient : IWeatherClient
	{
		private const string OpenWeatherMapApiKey = "3b0d16dab44859d1ecb30e52b478dd48";

		private readonly HttpClient _httpClient;

		public OpenWeatherClient(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<OpenWeatherResponse?> GetCurrentWeatherForCity(string city)
		{
			return
				await _httpClient.GetFromJsonAsync<OpenWeatherResponse>(
					$"forecast?q={city}&cnt=8&appid={OpenWeatherMapApiKey}&units=metric");
		}
    }
}

