using System.Text.Json.Serialization;

namespace WeatherForecast.ExternalApi.Models;

public record CityItem
{
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("country")]
    public string Country { get; init; }
}