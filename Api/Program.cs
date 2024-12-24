using Api.Configuration;
using Api.Middlewares;
using BusinessLayer.Configuration;
using DAL.Data;
using Elastic.Clients.Elasticsearch;
using Infrastructure.UnitOfWork;
using Infrastructure.UnitOfWork.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "BookHub API", Version = "v1" });

    c.AddSecurityDefinition(
        "Bearer",
        new OpenApiSecurityScheme
        {
            Description = "Enter the API key as follows: Bearer YourHardcodedToken",
            Name = "Authorization",
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.ApiKey,
            Scheme = "Bearer",
        }
    );

    c.AddSecurityRequirement(
        new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer",
                    },
                },
                Array.Empty<string>()
            },
        }
    );
});
builder.Services.AddSwaggerGen();
builder.Services.AddLogging();

var folder = Environment.SpecialFolder.LocalApplicationData;
var dbPath = Path.Join(Environment.GetFolderPath(folder), "bookhub.db");

builder.Services.AddDbContextFactory<BookHubDBContext>(options =>
    options
        .UseSqlite($"Data Source={dbPath}", x => x.MigrationsAssembly("DAL.SQLite.Migrations"))
        .UseLazyLoadingProxies()
);

builder.Services.AddDbContext<BookHubDBContext>();

builder.Services.Configure<ImageSettings>(builder.Configuration.GetSection("Images"));

builder.Services.AddSingleton<IImageUnitOfWork>(provider =>
{
    var imageSettings = provider.GetRequiredService<IOptions<ImageSettings>>().Value;
    return new ImageUnitOfWork(
        imageSettings.ImagesFolderPath,
        imageSettings.PreviewImagesFolderPath
    );
});

builder.Services.RegisterBusinessLogicServices();

builder.Services.Configure<RequestLogsSettings>(builder.Configuration.GetSection("RequestLogs"));

builder.Services.AddSingleton(provider =>
{
    var requestLogsSettings = provider.GetRequiredService<IOptions<RequestLogsSettings>>().Value;

    var elasticsearchUri = new Uri(requestLogsSettings.ElasticsearchUri);
    var settings = new ElasticsearchClientSettings(elasticsearchUri).DefaultIndex(
        requestLogsSettings.IndexName
    );
    return new ElasticsearchClient(settings);
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseMiddleware<RequestLoggingMiddleware>();
app.UseMiddleware<AuthorizationMiddleware>();
app.UseMiddleware<OutputFormatMiddleware>();
app.Run();
