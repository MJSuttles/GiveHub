using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using GiveHub.Data;
using GiveHub.Endpoint;
using GiveHub.Interfaces;
using GiveHub.Repositories;
using GiveHub.Services;

var builder = WebApplication.CreateBuilder(args);

// Enable legacy DateTime handling for PostgreSQL
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Get the connection string by name (uses Development override if present)
builder.Services.AddDbContext<GiveHubDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("GiveHubDb")));

// Optional debug output
Console.WriteLine("Connection String: " + builder.Configuration.GetConnectionString("GiveHubDb"));

// JSON options to prevent circular reference issues
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

// ✅ Register CORS policy BEFORE builder.Build()
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .WithOrigins("http://localhost:3000") // Frontend origin
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// Register repositories and services
builder.Services.AddScoped<IGiveHubCharityRepository, GiveHubCharityRepository>();
builder.Services.AddScoped<IGiveHubCharityService, GiveHubCharityService>();
builder.Services.AddScoped<IGiveHubEventRepository, GiveHubEventRepository>();
builder.Services.AddScoped<IGiveHubEventService, GiveHubEventService>();
builder.Services.AddScoped<IGiveHubTagRepository, GiveHubTagRepository>();
builder.Services.AddScoped<IGiveHubTagService, GiveHubTagService>();

// Swagger setup
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ Now we can build the app
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ✅ Use CORS AFTER building the app
app.UseCors();

app.MapCharityEndpoints();
app.MapEventEndpoints();
app.MapTagEndpoints();

app.Run();
