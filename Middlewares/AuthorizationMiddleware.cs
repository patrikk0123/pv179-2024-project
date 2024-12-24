using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Middlewares;

public class AuthorizationMiddleware(
    RequestDelegate next,
    ILogger<AuthorizationMiddleware> logger,
    IConfiguration configuration
)
{
    public async Task InvokeAsync(HttpContext context)
    {
        var endpoint = context.Features.Get<IEndpointFeature>()?.Endpoint;
        var attribute = endpoint?.Metadata.GetMetadata<AllowAnonymousAttribute>();

        if (attribute != null)
        {
            await next(context);
            return;
        }

        if (ValidateToken(context))
        {
            await next(context);
            return;
        }

        logger.LogError("Unauthorized request");
        var detailsFactory = context.RequestServices.GetRequiredService<ProblemDetailsFactory>();
        const int statusCode = (int)HttpStatusCode.Unauthorized;

        var details = detailsFactory.CreateProblemDetails(
            context,
            statusCode: statusCode,
            title: "Unauthorized"
        );
        context.Response.StatusCode = statusCode;
        await context.Response.WriteAsJsonAsync(details);
    }

    public bool ValidateToken(HttpContext context)
    {
        var header = context.Request.Headers["Authorization"].ToString();
        if (!header.StartsWith("Bearer ", StringComparison.CurrentCulture))
        {
            logger.LogError("wrong format: '{Header}'", header);
            return false;
        }
        var token = header[7..];
        var authenticated = string.CompareOrdinal(
                token,
                configuration.GetSection("Authorization:Token").Value
            )
            .Equals(0);

        if (!authenticated)
        {
            logger.LogError("invalid token: '{Token}'", token);
        }

        return authenticated;
    }
}
