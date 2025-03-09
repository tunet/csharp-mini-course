namespace WeatherForecastApi;

public record WeatherForecastConfig
{
    public required string BaseUrl { get; init; }
    public required string ApiKey { get; init; }
}