using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Application.Services.Interfaces;

namespace WeatherForecast.Web.Controllers;

[ApiController]
[Route("api/countries/{countryName}/cities")]
public class CityController(IWeatherForecastService weatherForecastService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetList([FromRoute] string countryName)
    {
        var response = await weatherForecastService.GetCityList(countryName);

        return Ok(response);
    }

    [HttpGet("{cityName}")]
    public async Task<IActionResult> Get(
        [FromRoute] string countryName,
        [FromRoute] string cityName
    )
    {
        var response = await weatherForecastService.GetCity(countryName, cityName);

        return Ok(response);
    }
}