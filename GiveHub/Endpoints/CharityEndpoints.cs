using GiveHub.Interfaces;
using GiveHub.Models;

namespace GiveHub.Endpoint
{
  public static class CharityEndpoints
  {
    // The endpoint layer is responsible for handling HTTP requests.
    // The endpoint layer will call the service layer to process business logic.
    // The endpoint layer will return the data to the client.
    // The endpoint layer is the entry point for the client to access the application.
    // We must register this MapWeatherEndpoints method in the Program.cs file.
    // You can click the reference to see where it is registered in the Program.cs file.

    public static void MapCharityEndpoints(this IEndpointRouteBuilder routes)
    {
      var group = routes.MapGroup("/api/charities").WithTags(nameof(Charity));

      // API calls

      group.MapGet("/", async (IGiveHubCharityService giveHubCharityService) =>
      {
        return await giveHubCharityService.GetAllCharitiesAsync();
      })
      .WithName("GetAllCharities")
      .WithOpenApi()
      .Produces<List<Charity>>(StatusCodes.Status200OK);

      group.MapGet("/{id}", async (int id, IGiveHubCharityService giveHubCharityService) =>
      {
        return await giveHubCharityService.GetCharityByIdAsync(id);
      })
      .WithName("GetCharityById")
      .WithOpenApi()
      .Produces<Charity>(StatusCodes.Status200OK);

      group.MapGet("/uid/{uid}", async (string uid, IGiveHubCharityService giveHubCharityService) =>
      {
        return await giveHubCharityService.GetCharityByUidAsync(uid);
      })
      .WithName("GetCharityByUid")
      .WithOpenApi()
      .Produces<Charity>(StatusCodes.Status200OK);
      
      group.MapPost("/", async (Charity charity, IGiveHubCharityService giveHubCharityService) =>
      {
        return await giveHubCharityService.CreateCharityAsync(charity);
      })
      .WithName("CreateCharity")
      .WithOpenApi()
      .Produces<Charity>(StatusCodes.Status201Created)
      .Produces(StatusCodes.Status400BadRequest);

      group.MapPut("/{id}", async (int id, Charity charity, IGiveHubCharityService giveHubCharityService) =>
      {
        return await giveHubCharityService.UpdateCharityAsync(id, charity);
      })
      .WithName("UpdateCharity")
      .WithOpenApi()
      .Produces<Charity>(StatusCodes.Status200OK)
      .Produces(StatusCodes.Status400BadRequest);

      group.MapDelete("/{id}", async (int id, IGiveHubCharityService giveHubCharityService) =>
      {
        return await giveHubCharityService.DeleteCharityAsync(id);
      })
      .WithName("DeleteCharity")
      .WithOpenApi()
      .Produces<Charity>(StatusCodes.Status204NoContent);
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
