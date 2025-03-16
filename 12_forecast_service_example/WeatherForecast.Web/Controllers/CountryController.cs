using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Application.Models;
using WeatherForecast.Application.Services.Interfaces;

namespace WeatherForecast.Web.Controllers;

[Authorize]
[ApiController]
[Route("api/countries")]
public class CountryController(IWeatherForecastService weatherForecastService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(List<CountryItem>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetList()
    {
        var response = await weatherForecastService.GetCountryList();

        return Ok(response);
    }

    [Authorize(Roles = "NotExistingRole")]
    [HttpGet("{countryName}")]
    [ProducesResponseType(typeof(Country), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get([FromRoute] string countryName)
    {
        var response = await weatherForecastService.GetCountry(countryName);

        return Ok(response);
    }
}