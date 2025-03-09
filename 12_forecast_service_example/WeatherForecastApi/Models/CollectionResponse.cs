using System.Text.Json.Serialization;

namespace WeatherForecastApi.Models;

public record CollectionResponse<T>
{
    [JsonPropertyName("items")]
    public List<T> Items { get; init; } = [];
}