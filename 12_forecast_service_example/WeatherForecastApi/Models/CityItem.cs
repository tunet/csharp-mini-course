using System.Text.Json.Serialization;

namespace WeatherForecastApi.Models;

public record CityItem
{
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("country")]
    public string Country { get; init; }
}