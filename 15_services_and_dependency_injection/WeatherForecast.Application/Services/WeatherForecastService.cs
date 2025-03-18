using WeatherForecast.Application.Models;
using WeatherForecast.Application.Services.Interfaces;

namespace WeatherForecast.Application.Services;

public class WeatherForecastService : IWeatherForecastService
{
    public List<CountryItem> GetCountryList()
    {
        return new List<CountryItem>
        {
            new CountryItem { Name = "UK" },
            new CountryItem { Name = "Canada" },
        };
    }

    public Country GetCountry(string countryName)
    {
        return new Country { Name = countryName, TemperatureC = 20 };
    }
}