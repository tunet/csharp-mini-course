namespace WeatherForecast.Application.Services.Interfaces;

public interface ITokenService
{
    string GenerateToken(string username);
}