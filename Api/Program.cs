using DAL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var folder = Environment.SpecialFolder.LocalApplicationData;
var dbPath = Path.Join(Environment.GetFolderPath(folder), "bookhub.db");

builder.Services.AddDbContextFactory<BookHubDBContext>(options =>
    options
        .UseSqlite($"Data Source={dbPath}", x => x.MigrationsAssembly("DAL.SQLite.Migrations"))
        .UseLazyLoadingProxies()
);

builder.Services.AddDbContext<BookHubDBContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
