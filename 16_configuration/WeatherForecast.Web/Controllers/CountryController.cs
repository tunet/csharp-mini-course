using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Application.Services.Interfaces;

namespace WeatherForecast.Web.Controllers;

[ApiController]
[Route("api/countries")]
public class CountryController(IWeatherForecastService weatherForecastService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetList()
    {
        var response = weatherForecastService.GetCountryList();

        return Ok(response);
    }

    [HttpGet("{countryName}")]
    public IActionResult Get([FromRoute] string countryName)
    {
        var response = weatherForecastService.GetCountry(countryName);

        return Ok(response);
    }
}