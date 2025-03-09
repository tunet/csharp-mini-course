namespace WeatherForecast.Application.Models;

public sealed record CityItem
{
    public required string Name { get; init; }
    public required string Country { get; init; }
}