using System.Text.Json.Serialization;

namespace WeatherForecast.ExternalApi.Models;

public record CountryItem
{
    [JsonPropertyName("name")]
    public string Name { get; init; }
}