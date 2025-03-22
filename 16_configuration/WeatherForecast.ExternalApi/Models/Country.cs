using System.Text.Json.Serialization;

namespace WeatherForecast.ExternalApi.Models;

public record Country
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("temperature_c")]
    public required int TemperatureC { get; init; }
}