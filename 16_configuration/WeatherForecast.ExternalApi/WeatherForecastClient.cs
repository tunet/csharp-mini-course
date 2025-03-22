using System.Text.Json;
using Microsoft.Extensions.Options;
using WeatherForecast.ExternalApi.Models;

namespace WeatherForecast.ExternalApi;

public class WeatherForecastClient : IWeatherForecastClient
{
    private readonly HttpClient _httpClient;
    private readonly WeatherForecastConfig _config;

    public WeatherForecastClient(HttpClient httpClient, IOptions<WeatherForecastConfig> config)
    {
        _httpClient = httpClient;
        _config = config.Value;

        _httpClient.BaseAddress = new Uri(_config.BaseUrl);
        _httpClient.DefaultRequestHeaders.Add("X-Api-Key", _config.ApiKey);
    }

    public async Task<CollectionResponse<CountryItem>> GetCountryList()
    {
        var response = await _httpClient.GetAsync("api/countries");
        var content = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<CollectionResponse<CountryItem>>(content)
               ?? throw new Exception("Failed to deserialize response");
    }

    public async Task<Country> GetCountry(string countryName)
    {
        var response = await _httpClient.GetAsync($"api/countries/{countryName}");
        var content = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<Country>(content) ?? throw new Exception("Failed to deserialize response");
    }

    public async Task<CollectionResponse<CityItem>> GetCityList()
    {
        var response = await _httpClient.GetAsync("api/cities");
        var content = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<CollectionResponse<CityItem>>(content)
               ?? throw new Exception("Failed to deserialize response");
    }

    public async Task<City> GetCity(int id)
    {
        var response = await _httpClient.GetAsync($"api/cities/{id}");
        var content = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<City>(content) ?? throw new Exception("Failed to deserialize response");
    }
}