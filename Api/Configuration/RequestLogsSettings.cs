namespace Api.Configuration;

public class RequestLogsSettings
{
    public required string ElasticsearchUri { get; set; }
    public required string IndexName { get; set; }
}
