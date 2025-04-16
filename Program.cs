using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using GiveHub.Data;
using GiveHub.Endpoint;
using GiveHub.Interfaces;
using GiveHub.Repositories;
using GiveHub.Services;

var builder = WebApplication.CreateBuilder(args);

// ✅ Enables legacy timestamp behavior (for compatibility with DateTime)
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// ✅ Configure EF Core to use Npgsql with the connection string from appsettings.json or user secrets
builder.Services.AddDbContext<GiveHubDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("BrianDb")));

// ✅ Set the JSON serializer to avoid circular reference issues
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

// ✅ Register repositories and services for dependency injection
builder.Services.AddScoped<IGiveHubCharityRepository, GiveHubCharityRepository>();
builder.Services.AddScoped<IGiveHubCharityService, GiveHubCharityService>();
builder.Services.AddScoped<IGiveHubEventRepository, GiveHubEventRepository>();
builder.Services.AddScoped<IGiveHubEventService, GiveHubEventService>();
builder.Services.AddScoped<IGiveHubTagRepository, GiveHubTagRepository>();
builder.Services.AddScoped<IGiveHubTagService, GiveHubTagService>();

// ✅ Swagger / API docs setup
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ✅ Enable Swagger UI in development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ✅ Middleware setup
app.UseHttpsRedirection();

// ✅ Map endpoint groups (routes)
app.MapCharityEndpoints();
app.MapEventEndpoints();
app.MapTagEndpoints();

app.Run();
