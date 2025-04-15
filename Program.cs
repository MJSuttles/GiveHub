using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using GiveHub.Data;
using GiveHub.Endpoint;
using GiveHub.Interfaces;
using GiveHub.Repositories;
using GiveHub.Services;


var builder = WebApplication.CreateBuilder(args);

// allows passing datimes without time zone data
AppContext.SetSwitch("Npgsql.EnablelegacyTimestampBehavior", true);

// allows our api endpoints to access the data through Entity Framework Configure
builder.Services.AddNpgsql<SimplyBooksDbContext>(builder.Configuration["SimplyBooks-BEConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options => { options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; });

// Here we are registering the services and repositories with the DI container.
// The DI container will inject the services and repositories into the endpoints (controllers).
// DI (Dependency Injection) is a design pattern that allows us to develop loosely coupled code.
// Loosely coupled code is code where the classes and objects are independent of each other.
// This makes the code easier to maintain, test, and extend.

builder.Services.AddScoped<IGiveHubCharityRepository, GiveHubCharityRepository>();
builder.Services.AddScoped<IGiveHubCharityService, GiveHubCharityService>();
builder.Services.AddScoped<IGiveHubEventRepository, GiveHubEventRepository>();
builder.Services.AddScoped<IGiveHubEventService, GiveHubEventService>();
builder.Services.AddScoped<IGiveHubTagRepository, GiveHubTagRepository>();
builder.Services.AddScoped<IGiveHubTagService, GiveHubTagService>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
