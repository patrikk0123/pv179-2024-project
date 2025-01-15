using Elastic.Clients.Elasticsearch;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Middlewares.Configuration;

public static class LoggingConfiguration
{
    public static IServiceCollection RegisterLogging(this IServiceCollection services)
    {
        var serviceProvider = services.BuildServiceProvider();
        var configuration = serviceProvider.GetRequiredService<IConfiguration>();

        services.Configure<RequestLogsSettings>(configuration.GetSection("RequestLogs"));

        services.AddSingleton(provider =>
        {
            var requestLogsSettings = provider
                .GetRequiredService<IOptions<RequestLogsSettings>>()
                .Value;

            var elasticsearchUri = new Uri(requestLogsSettings.ElasticsearchUri);
            var settings = new ElasticsearchClientSettings(elasticsearchUri).DefaultIndex(
                requestLogsSettings.IndexName
            );
            return new ElasticsearchClient(settings);
        });

        return services;
    }
}
