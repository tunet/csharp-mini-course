using System.Text.Json.Serialization;

namespace WeatherForecast.ExternalApi.Models;

public record CollectionResponse<T>
{
    [JsonPropertyName("items")]
    public required List<T> Items { get; init; }
}