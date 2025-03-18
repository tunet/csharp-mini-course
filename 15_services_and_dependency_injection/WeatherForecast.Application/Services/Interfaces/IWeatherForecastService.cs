using WeatherForecast.Application.Models;

namespace WeatherForecast.Application.Services.Interfaces;

public interface IWeatherForecastService
{
    List<CountryItem> GetCountryList();
    Country GetCountry(string countryName);
}