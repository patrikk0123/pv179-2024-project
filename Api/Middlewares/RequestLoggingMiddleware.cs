using Api.Configuration.LogEntities;
using Elastic.Clients.Elasticsearch;

namespace Api.Middlewares;

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
                await elasticClient.IndexAsync(logEntry, i => i.Index("logs"));
            }
            catch (Exception e)
            {
                logger.LogWarning(e.Message);
            }
        }
    }
}
