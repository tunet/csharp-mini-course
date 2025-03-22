using WeatherForecast.ExternalApi.Models;

namespace WeatherForecast.ExternalApi;

public interface IWeatherForecastClient
{
    Task<CollectionResponse<CountryItem>> GetCountryList();
    Task<Country> GetCountry(string countryName);
    Task<CollectionResponse<CityItem>> GetCityList();
    Task<City> GetCity(int id);
}