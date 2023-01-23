using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WeatherApp.Models
{
    public class OpenWeatherResponse
    {
        public IEnumerable<WeatherDTO> List { get; set; }

        public City City { get; set; }
    }

    public class WeatherDTO
    {
        public Wind Wind { get; set; }

        public Main Main { get; set; }

        public Rain Rain { get; set; }

        public string Dt_txt { get; set; }

        //public IEnumerable<WeatherDescription> Weather { get; set; }
    }

    public class City
    {
        public string Name { get; set; }
    }

    public class Rain
    {
        [JsonPropertyName("3h")]
        public float Amount { get; set; }
    }

    public class Main
    {
        public float Temp { get; set; }
        public float Temp_min { get; set; }
        public float Temp_max { get; set; }
    }

    public class Wind
    {
        public float Speed { get; set; }
        public float Deg { get; set; }
    }

    public class WeatherDescription
    {
        public string Main { get; set; }
        public string Description { get; set; }
    }
}

