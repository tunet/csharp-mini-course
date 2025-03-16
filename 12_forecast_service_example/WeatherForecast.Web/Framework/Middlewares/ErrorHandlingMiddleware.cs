using System.Net;
using System.Text.Json;
using WeatherForecast.Common.Exceptions;

namespace WeatherForecast.Web.Framework.Middlewares;

public class ErrorHandlingMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext context, IHostEnvironment env, ILogger<ErrorHandlingMiddleware> logger)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);

            await HandleException(context, ex, env);
        }
    }

    private Task HandleException(HttpContext context, Exception ex, IHostEnvironment env)
    {
        return ex switch
        {
            ApiException apiException => HandleApiException(context, apiException, env),
            AppException appException => HandleAppException(context, appException, env),
            _ => HandleBaseException(context, ex, env),
        };
    }

    private async Task HandleApiException(HttpContext context, ApiException ex, IHostEnvironment env)
    {
        context.Response.StatusCode = (int)ex.StatusCode;
        context.Response.ContentType = "application/json";

        object errorResponse = env.IsDevelopment()
            ? new { error = ex.Content, message = ex.Message, stackTrace = ex.StackTrace }
            : new { error = ex.Content };

        await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
    }

    private async Task HandleAppException(HttpContext context, AppException ex, IHostEnvironment env)
    {
        context.Response.StatusCode = (int)ex.StatusCode;
        context.Response.ContentType = "application/json";

        object errorResponse = env.IsDevelopment()
            ? new { error = ex.Message, stackTrace = ex.StackTrace }
            : new { error = ex.Message };

        await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
    }

    private async Task HandleBaseException(HttpContext context, Exception ex, IHostEnvironment env)
    {
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        context.Response.ContentType = "application/json";

        object errorResponse = env.IsDevelopment()
            ? new { message = ex.Message, stackTrace = ex.StackTrace }
            : new { message = "Something went wrong" };

        await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
    }
}