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

// Here we are calling the extension method MapWeatherEndpoints() to map the weather endpoints.
// The extension method is defined in the WeatherForecastEndpoints class.
// The extension method is a static method that extends the IEndpointRouteBuilder interface.
// The extension method is used to group related endpoints together.
// An extension method is a special kind of static method that is used to add new functionality to existing types.
// A static method is a method that belongs to the class itself, not to instances of the class.

app.MapCharityEndpoints();
app.MapEventEndpoints();
app.MapTagEndpoints();

app.Run();
