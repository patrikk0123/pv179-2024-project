using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Api.Middlewares
{
    public class AuthorizationMiddleware(RequestDelegate next, IConfiguration configuration)
    {
        private readonly RequestDelegate _next = next;

        public async Task InvokeAsync(HttpContext context)
        {
            var endpoint = context.Features.Get<IEndpointFeature>()?.Endpoint;
            var attribute = endpoint?.Metadata.GetMetadata<AllowAnonymousAttribute>();

            if (attribute != null)
            {
                await _next(context);
                return;
            }

            if (ValidateToken(context))
            {
                await _next(context);
                return;
            }

            var detailsFactory =
                context.RequestServices.GetRequiredService<ProblemDetailsFactory>();
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
                Console.WriteLine($"wrong format: '{header}'");
                return false;
            }
            var token = header[7..];
            return token.Equals(configuration.GetSection("Authorization:Token").Value!);
        }
    }
}
