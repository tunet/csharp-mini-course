using System.Text.Json;
using WeatherForecastApi.Models;
using Microsoft.Extensions.Options;

namespace WeatherForecastApi;

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

    public Task<CollectionResponse<CountryItem>> GetCountryList()
    {
        return Get<CollectionResponse<CountryItem>>("api/countries");
    }

    public Task<Country> GetCountry(string name)
    {
        return Get<Country>($"api/countries/{name}");
    }

    public Task<CollectionResponse<CityItem>> GetCityList()
    {
        return Get<CollectionResponse<CityItem>>("api/cities");
    }

    public Task<City> GetCity(int id)
    {
        return Get<City>($"api/cities/{id}");
    }

    private async Task<T> Get<T>(string url)
    {
        var response = await _httpClient.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(
                $"""
                 Error: {response.ReasonPhrase},
                 Status code: {response.StatusCode},
                 Content: {content}
                 """
            );
        }

        return JsonSerializer.Deserialize<T>(content) ?? throw new Exception("Failed to deserialize response");
    }
}