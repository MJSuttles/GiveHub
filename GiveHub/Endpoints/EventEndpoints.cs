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

      // example

      // group.MapGet("/", async (ISimplyBooksAuthorService simplyBooksAuthorService) =>
      // {
      //   return await simplyBooksAuthorService.GetAllAuthorsAsync();
      // })
      // .WithName("GetAllAuthors")
      // .WithOpenApi()
      // .Produces<List<Author>>(StatusCodes.Status200OK);

      // Status StatusCodes

      // GET Calls:

      // .Produces<List<Author>>(StatusCodes.Status200OK);

      // POST Calls:

      // .Produces<Author>(StatusCodes.Status201Created)
      // .Produces(StatusCodes.Status400BadRequest);

      // PUT Calls:

      // .Produces<Author>(StatusCodes.Status201Created)
      // .Produces(StatusCodes.Status400BadRequest);

      // DELETE Calls:

      // .Produces<Author>(StatusCodes.Status204NoContent);
    }
  }
}
