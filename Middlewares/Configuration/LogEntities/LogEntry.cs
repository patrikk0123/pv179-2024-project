namespace Middlewares.Configuration.LogEntities;

public class LogEntry
{
    public RequestDetails Request { get; set; } = new();
    public ResponseDetails Response { get; set; } = new();
    public DateTime Timestamp { get; set; }
    public string? AuthorizationToken { get; set; }
    public double DurationMilliseconds { get; set; }
}
