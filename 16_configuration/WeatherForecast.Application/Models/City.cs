namespace WeatherForecast.Application.Models;

public record City
{
    public required string Name { get; init; }
    public required string Country { get; init; }
    public required int TemperatureC { get; init; }
}