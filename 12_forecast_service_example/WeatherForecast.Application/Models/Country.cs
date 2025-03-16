namespace WeatherForecast.Application.Models;

public sealed record Country
{
    public required string Name { get; init; }
    public required int TemperatureC { get; init; }
}