using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Application.Services.Interfaces;
using WeatherForecast.Web.Models;

namespace WeatherForecast.Web.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController(ITokenService tokenService) : ControllerBase
{
    [HttpPost]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (request.Username == "admin" && request.Password == "password123")
        {
            var token = tokenService.GenerateToken(request.Username);

            return Ok(new { token });
        }

        return Unauthorized("Invalid credentials");
    }
}