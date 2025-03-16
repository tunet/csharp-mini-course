using System.Text.Json.Serialization;

namespace WeatherForecast.ExternalApi.Models;

public record Country
{
    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("temperature_c")]
    public int TemperatureC { get; init; }
}