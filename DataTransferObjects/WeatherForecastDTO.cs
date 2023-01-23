using System;
namespace WeatherApp.DataTransferObjects
{
	public class WeatherForecastDTO
	{
		public string Date { get; set; }
		public float TemperatureMin { get; set; }
        public float TemperatureMax { get; set; }
		public float Rain { get; set; }
        public float WindSpeed { get; set; }
        public float WindDeg { get; set; }
    }
}

