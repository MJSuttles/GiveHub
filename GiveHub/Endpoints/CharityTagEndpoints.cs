using GiveHub.Interfaces;
using GiveHub.Models;

namespace GiveHub.Endpoint
{
  public static class CharityTagEndpoints
  {
    // The endpoint layer is responsible for handling HTTP requests.
    // The endpoint layer will call the service layer to process business logic.
    // The endpoint layer will return the data to the client.
    // The endpoint layer is the entry point for the client to access the application.
    // We must register this MapWeatherEndpoints method in the Program.cs file.
    // You can click the reference to see where it is registered in the Program.cs file.

    public static void MapCharityTagEndpoints(this IEndpointRouteBuilder routes)
    {
      var group = routes.MapGroup("/api/charityTags").WithTags(nameof(Tag));

      // API calls

      // example

    group.MapPost("/", async (CharityTag charityTag, IGiveHubCharityTagService giveHubCharityTagService) =>
    {
        var newCharityTag = await giveHubCharityTagService.CreateCharityTagAsync(charityTag);
        return Results.Created($"/api/charitytags/{newCharityTag.CharityId}/{newCharityTag.TagId}", newCharityTag);
    })
    .WithName("CreateCharityTag")
    .WithOpenApi()
    .Produces<CharityTag>(StatusCodes.Status201Created);

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
