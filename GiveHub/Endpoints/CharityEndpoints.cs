using GiveHub.Interfaces;
using GiveHub.Models;

namespace SimplyBooks.Endpoint
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
    }
  }
}
