using GiveHub.Interfaces;
using GiveHub.Models;
using GiveHub.Repositories;

namespace GiveHub.Services
{
  public class GiveHubEventService : IGiveHubEventService
  {
    // The service layer is responsible for processing business logic.
    // Right now, the service layer is just calling the repository layer.
    // The service layer will call the repository layer to do the actual CRUD operations.
    // The service layer will return the data to the endpoint (controller).

    private readonly IGiveHubEventRepository _giveHubEventRepository;

    // This constructor is used for dependency injection.
    // We are injecting the ISimplyBooksAuthorRepository interface into the SimplyBooksAuthorRepository class.
    // We inject the repository interface instead of the actual repository class.
    // This is because we can easily mock the interface for unit testing.
    // It also makes our code more flexible and easier to maintain.
    // The type of DI used here is called constructor injection.

    public GiveHubEventService(IGiveHubEventRepository giveHubEventRepository)
    {
      _giveHubEventRepository = giveHubEventRepository;
    }

    // async means that the method is asynchronous.
    // async methods can be awaited using the await keyword.
    // async methods return a Task or Task<T>.
    // Task represents an asynchronous operation that can return a value.
    // Task<T> is a task that returns a value.
    // To get the value, we use the await keyword.

    // seed data

    public async Task<Event> CreateEventAsync(Event eventEntity)
    {
      return await _giveHubEventRepository.CreateEventAsync(eventEntity);
    }

    public async Task<Event> UpdateEventAsync(int id, Event eventEntity)
    {
      return await _giveHubEventRepository.UpdateEventAsync(id, eventEntity);
    }

    public async Task<Event> DeleteEventAsync(int id)
    {
      return await _giveHubEventRepository.DeleteEventAsync(id);
    }
  }
}
