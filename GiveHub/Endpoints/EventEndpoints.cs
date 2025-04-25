using GiveHub.Interfaces;
using GiveHub.Models;

namespace GiveHub.Endpoint
{
  public static class EventEndpoints
  {
    // The endpoint layer is responsible for handling HTTP requests.
    // The endpoint layer will call the service layer to process business logic.
    // The endpoint layer will return the data to the client.
    // The endpoint layer is the entry point for the client to access the application.
    // We must register this MapWeatherEndpoints method in the Program.cs file.
    // You can click the reference to see where it is registered in the Program.cs file.

    public static void MapEventEndpoints(this IEndpointRouteBuilder routes)
    {
      var group = routes.MapGroup("/api/events").WithTags(nameof(Event));

      // API calls
      group.MapGet("/{id}", async (int id, IGiveHubEventService giveHubEventService) =>
      {
          return await giveHubEventService.GetEventByIdAsync(id);
      })
      .WithName("GetEventById")
      .WithOpenApi()
      .Produces<Event>(StatusCodes.Status200OK);

      group.MapGet("/charity/{charityId}", async (int charityId, IGiveHubEventService giveHubEventService) =>
      {
        return await giveHubEventService.GetEventsByCharityIdAsync(charityId);
      })
      .WithName("GetEventsByCharityId")
      .WithOpenApi()
      .Produces<List<Event>>(StatusCodes.Status200OK);

      group.MapPost("/", async (Event eventEntity, IGiveHubEventService giveHubEventService) =>
      {
        return await giveHubEventService.CreateEventAsync(eventEntity);
      })
      .WithName("CreateEvent")
      .WithOpenApi()
      .Produces<Event>(StatusCodes.Status201Created);
      // .Produces(StatusCodes.Status400BadRequest);

      group.MapPut("/{id}", async (int id, Event eventEntity, IGiveHubEventService giveHubEventService) =>
      {
        return await giveHubEventService.UpdateEventAsync(id, eventEntity);
      })
      .WithName("UpdateEvent")
      .WithOpenApi()
      .Produces<Event>(StatusCodes.Status200OK)
      .Produces(StatusCodes.Status400BadRequest);

      group.MapDelete("/{id}", async (int id, IGiveHubEventService giveHubEventService) =>
      {
        return await giveHubEventService.DeleteEventAsync(id);
      })
      .WithName("DeleteEvent")
      .WithOpenApi()
      .Produces<Event>(StatusCodes.Status204NoContent);
    }
  }
}
