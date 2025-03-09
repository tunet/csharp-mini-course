using System.Text.Json.Serialization;

namespace WeatherForecastApi.Models;

public record CountryItem
{
    [JsonPropertyName("name")]
    public string Name { get; init; }
}