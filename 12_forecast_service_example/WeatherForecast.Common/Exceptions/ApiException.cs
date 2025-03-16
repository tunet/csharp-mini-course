using System.Net;

namespace WeatherForecast.Common.Exceptions;

public class ApiException(HttpStatusCode statusCode, string? content, string? message) : Exception(message)
{
    public HttpStatusCode StatusCode => statusCode;
    public string? Content => content;
}