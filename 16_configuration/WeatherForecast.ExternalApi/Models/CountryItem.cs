using System.Text.Json.Serialization;

namespace WeatherForecast.ExternalApi.Models;

public record CountryItem
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}