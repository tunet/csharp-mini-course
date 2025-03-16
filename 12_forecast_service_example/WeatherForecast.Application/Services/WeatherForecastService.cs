using System.Net;
using WeatherForecast.Application.Models;
using WeatherForecast.Application.Services.Interfaces;
using WeatherForecast.Common.Exceptions;
using WeatherForecast.ExternalApi;

namespace WeatherForecast.Application.Services;

public class WeatherForecastService(IWeatherForecastClient weatherForecastClient) : IWeatherForecastService
{
    public async Task<List<CountryItem>> GetCountryList()
    {
        var response = await weatherForecastClient.GetCountryList();

        return response.Items
            .Select(c => new CountryItem { Name = c.Name })
            .ToList();
    }

    public async Task<List<Country>> GetCountryListV2()
    {
        var response = await weatherForecastClient.GetCountryList();

        var tasks = response.Items
            .Select(c => GetCountry(c.Name))
            .ToList();

        return (await Task.WhenAll(tasks)).ToList();
    }

    public async Task<Country> GetCountry(string countryName)
    {
        var response = await weatherForecastClient.GetCountry(countryName);

        return new Country { Name = response.Name, TemperatureC = response.TemperatureC };
    }

    public async Task<List<CityItem>> GetCityList(string countryName)
    {
        var response = await weatherForecastClient.GetCityList();

        return response.Items
            .Where(c => c.Country == countryName)
            .Select(c => new CityItem { Name = c.Name, Country = countryName })
            .ToList();
    }

    public async Task<City> GetCity(string countryName, string cityName)
    {
        var response = await weatherForecastClient.GetCityList();

        var cityItem = response.Items
            .FirstOrDefault(c => c.Country == countryName && c.Name == cityName)
            ?? throw new AppException(HttpStatusCode.NotFound, "City not found");

        var city = await weatherForecastClient.GetCity(cityItem.Id);

        return new City { Name = city.Name, Country = countryName, TemperatureC = city.TemperatureC };
    }
}