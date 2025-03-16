using System.Net;

namespace WeatherForecast.Common.Exceptions;

public class AppException(HttpStatusCode statusCode, string message) : Exception(message)
{
    public HttpStatusCode StatusCode => statusCode;
}