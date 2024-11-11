using Api.Mappers;
using Api.Mappers.Interfaces;
using Api.Middlewares;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
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

builder.Services.AddSingleton<IBookMapper, BookMapper>();
builder.Services.AddSingleton<IBookReviewMapper, BookReviewMapper>();
builder.Services.AddSingleton<IPublisherMapper, PublisherMapper>();
builder.Services.AddSingleton<IAuthorMapper, AuthorMapper>();
builder.Services.AddSingleton<IGenreMapper, GenreMapper>();
builder.Services.AddSingleton<IUserMapper, UserMapper>();
builder.Services.AddSingleton<IWishListItemMapper, WishListItemMapper>();
builder.Services.AddSingleton<IOrderMapper, OrderMapper>();

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
app.Run();
