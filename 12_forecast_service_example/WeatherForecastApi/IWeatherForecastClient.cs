using WeatherForecastApi.Models;

namespace WeatherForecastApi;

public interface IWeatherForecastClient
{
    Task<CollectionResponse<CountryItem>> GetCountryList();
    Task<Country> GetCountry(string name);
    Task<CollectionResponse<CityItem>> GetCityList();
    Task<City> GetCity(int id);
}