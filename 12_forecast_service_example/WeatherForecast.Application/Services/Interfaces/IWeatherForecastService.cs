using WeatherForecast.Application.Models;

namespace WeatherForecast.Application.Services.Interfaces;

public interface IWeatherForecastService
{
    Task<List<CountryItem>> GetCountryList();
    Task<List<Country>> GetCountryListV2();
    Task<Country> GetCountry(string countryName);
    Task<List<CityItem>> GetCityList(string countryName);
    Task<City> GetCity(string countryName, string cityName);
}