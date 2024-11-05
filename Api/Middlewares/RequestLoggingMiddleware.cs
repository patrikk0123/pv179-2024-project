namespace Api.Middlewares;

public class RequestLoggingMiddleware(
    RequestDelegate next,
    ILogger<RequestLoggingMiddleware> logger
)
{
    public async Task Invoke(HttpContext context)
    {
        var startTime = DateTime.UtcNow;

        if (logger.IsEnabled(LogLevel.Information))
        {
            var request = context.Request;
            logger.LogInformation(
                $"Received request: {request.Method} {request.Path}{request.QueryString}"
            );
        }

        context.Response.OnStarting(() =>
        {
            var duration = DateTime.UtcNow - startTime;

            if (logger.IsEnabled(LogLevel.Information))
            {
                var response = context.Response;
                logger.LogInformation(
                    $"Sending response: {response.StatusCode}. Duration: {duration.TotalMilliseconds} ms."
                );
            }

            return Task.CompletedTask;
        });

        await next(context);
    }
}
