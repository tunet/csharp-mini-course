namespace WeatherForecast.ExternalApi;

public record WeatherForecastConfig
{
    public required string BaseUrl { get; init; }
    public required string ApiKey { get; init; }
}