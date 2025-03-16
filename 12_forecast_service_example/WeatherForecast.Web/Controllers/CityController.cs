using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Application.Models;
using WeatherForecast.Application.Services.Interfaces;

namespace WeatherForecast.Web.Controllers;

[ApiController]
[Route("api/countries/{countryName}/cities")]
public class CityController(IWeatherForecastService weatherForecastService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(List<CityItem>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetList([FromRoute] string countryName)
    {
        var response = await weatherForecastService.GetCityList(countryName);

        return Ok(response);
    }

    [HttpGet("{cityName}")]
    [ProducesResponseType(typeof(City), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(
        [FromRoute] string countryName,
        [FromRoute] string cityName
    )
    {
        var response = await weatherForecastService.GetCity(countryName, cityName);

        return Ok(response);
    }
}