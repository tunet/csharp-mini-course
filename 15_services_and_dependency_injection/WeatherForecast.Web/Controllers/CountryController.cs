using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Application.Models;
using WeatherForecast.Application.Services.Interfaces;

namespace WeatherForecast.Web.Controllers;

[ApiController]
[Route("api/countries")]
public class CountryController(IWeatherForecastService weatherForecastService) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(List<CountryItem>), StatusCodes.Status200OK)]
    public IActionResult GetList()
    {
        var response = weatherForecastService.GetCountryList();

        return Ok(response);
    }

    [HttpGet("{countryName}")]
    [ProducesResponseType(typeof(Country), StatusCodes.Status200OK)]
    public IActionResult Get([FromRoute] string countryName)
    {
        var response = weatherForecastService.GetCountry(countryName);

        return Ok(response);
    }
}