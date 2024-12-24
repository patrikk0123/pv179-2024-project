namespace Middlewares.Configuration.LogEntities;

public class RequestDetails
{
    public string Method { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public string QueryString { get; set; } = string.Empty;
}
