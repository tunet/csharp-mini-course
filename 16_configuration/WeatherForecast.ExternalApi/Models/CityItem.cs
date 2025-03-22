using System.Text.Json.Serialization;

namespace WeatherForecast.ExternalApi.Models;

public record CityItem
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }
    
    [JsonPropertyName("name")]
    public required string Name { get; init; }
    
    [JsonPropertyName("country")]
    public required string Country { get; init; }
}