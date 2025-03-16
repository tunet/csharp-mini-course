namespace WeatherForecast.Application;

public record JwtConfig
{
    public required string Key { get; init; }
    public required string Issuer { get; init; }
}