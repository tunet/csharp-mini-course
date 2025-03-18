using Microsoft.AspNetCore.Mvc;

namespace WeatherForecast.Web.Controllers;

[ApiController]
[Route("api/countries")]
public class CountryController : ControllerBase
{
    [HttpGet]
    public IActionResult GetList()
    {
        List<string> countryList = ["UK", "Canada"];

        return Ok(countryList);
    }

    [HttpGet("{countryName}")]
    public IActionResult Get([FromRoute] string countryName)
    {
        var response = new { country = countryName };

        return Ok(response);
    }
}