using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WeatherForecast.Application.Services.Interfaces;

namespace WeatherForecast.Web.Controllers;

[ApiController]
[Route("api/countries")]
public class CountryController(
    IWeatherForecastService weatherForecastService,
    IOptions<TestConfig> testConfig
) : ControllerBase
{
    private TestConfig Config { get; } = testConfig.Value;

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

    [HttpGet("config")]
    [ProducesResponseType(typeof(TestConfig), StatusCodes.Status200OK, "application/json")]
    public IActionResult GetConfig()
    {
        return Ok(Config);
    }
}