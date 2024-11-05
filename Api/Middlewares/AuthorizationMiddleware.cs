using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Api.Middlewares;

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
            logger.LogError("wrong format: '{header}'", header);
            return false;
        }
        var token = header[7..];
        var authenticated = token.Equals(configuration.GetSection("Authorization:Token").Value!);

        if (!authenticated)
        {
            logger.LogError("invalid token: '{token}'", token);
        }

        return authenticated;
    }
}
