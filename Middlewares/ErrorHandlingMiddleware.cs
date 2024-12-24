using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Middlewares;

public class ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
{
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            logger.LogError("{Error}", ex.ToString());
            await HandleResponseAsync(context);
        }
    }

    private static Task HandleResponseAsync(HttpContext context)
    {
        var detailsFactory = context.RequestServices.GetRequiredService<ProblemDetailsFactory>();
        const int statusCode = (int)HttpStatusCode.InternalServerError;

        var details = detailsFactory.CreateProblemDetails(
            context,
            statusCode: statusCode,
            title: "Internal Server Error"
        );
        context.Response.StatusCode = statusCode;
        return context.Response.WriteAsJsonAsync(details);
    }
}
