using Elastic.Clients.Elasticsearch;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Middlewares.Configuration.LogEntities;

namespace Middlewares;

public class RequestLoggingMiddleware(
    RequestDelegate next,
    ElasticsearchClient elasticClient,
    ILogger<RequestLoggingMiddleware> logger
)
{
    public async Task Invoke(HttpContext context)
    {
        var startTime = DateTime.UtcNow;

        context.Request.Headers.TryGetValue("Authorization", out var authToken);

        var logEntry = new LogEntry
        {
            Request = new RequestDetails
            {
                Method = context.Request.Method,
                Path = context.Request.Path.ToString(),
                QueryString = context.Request.QueryString.ToString(),
            },
            Timestamp = startTime,
            AuthorizationToken = authToken.ToString(),
            DurationMilliseconds = 0.0,
        };

        try
        {
            await next(context);
        }
        finally
        {
            var duration = DateTime.UtcNow - startTime;
            logEntry.Response.StatusCode = context.Response.StatusCode;
            logEntry.DurationMilliseconds = duration.TotalMilliseconds;
            try
            {
                await elasticClient.IndexAsync(logEntry);
            }
            catch (Exception e)
            {
                logger.LogWarning(e.Message);
            }
        }
    }
}
