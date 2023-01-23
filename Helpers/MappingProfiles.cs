using System;
using AutoMapper;
using System.Net;
using WeatherApp.DataTransferObjects;
using WeatherApp.Models;

namespace WeatherApp.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<OpenWeatherResponse, WeatherForecastDTO>();
        }
    }
}

