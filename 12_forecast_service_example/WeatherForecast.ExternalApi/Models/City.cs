using System.Text.Json.Serialization;

namespace WeatherForecast.ExternalApi.Models;

public record City
{
    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("country")]
    public string Country { get; init; }

    [JsonPropertyName("temperature_c")]
    public int TemperatureC { get; init; }
}