using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Application.Services.Interfaces;

namespace WeatherForecast.Web.Controllers;

[ApiController]
[Route("api/countries")]
public class CountryController(IWeatherForecastService weatherForecastService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetList()
    {
        var response = await weatherForecastService.GetCountryList();

        return Ok(response);
    }

    [HttpGet("{countryName}")]
    public async Task<IActionResult> Get([FromRoute] string countryName)
    {
        var response = await weatherForecastService.GetCountry(countryName);

        return Ok(response);
    }
}