using GiveHub.Interfaces;
using GiveHub.Models;
using GiveHub.Repositories;

namespace GiveHub.Services
{
  public class GiveHubCharityService : IGiveHubCharityService
  {
    // The service layer is responsible for processing business logic.
    // Right now, the service layer is just calling the repository layer.
    // The service layer will call the repository layer to do the actual CRUD operations.
    // The service layer will return the data to the endpoint (controller).

    private readonly IGiveHubCharityRepository _giveHubCharityRepository;

    // This constructor is used for dependency injection.
    // We are injecting the ISimplyBooksAuthorRepository interface into the SimplyBooksAuthorRepository class.
    // We inject the repository interface instead of the actual repository class.
    // This is because we can easily mock the interface for unit testing.
    // It also makes our code more flexible and easier to maintain.
    // The type of DI used here is called constructor injection.

    public GiveHubCharityService(IGiveHubCharityRepository giveHubCharityRepository)
    {
      _giveHubCharityRepository = giveHubCharityRepository;
    }

    // async means that the method is asynchronous.
    // async methods can be awaited using the await keyword.
    // async methods return a Task or Task<T>.
    // Task represents an asynchronous operation that can return a value.
    // Task<T> is a task that returns a value.
    // To get the value, we use the await keyword.

    // seed data

    public async Task<List<Charity>> GetAllCharitiesAsync()
    {
      return await _giveHubCharityRepository.GetAllCharitiesAsync();
    }

    public async Task<Charity> GetCharityByIdAsync(int id)
    {
      return await _giveHubCharityRepository.GetCharityByIdAsync(id);
    }

    public async Task<Charity> GetCharityByUidAsync(string uid)
    {
      return await _giveHubCharityRepository.GetCharityByUidAsync(uid);
    }

    public async Task<Charity> CreateCharityAsync(Charity charity)
    {
      return await _giveHubCharityRepository.CreateCharityAsync(charity);
    }

    public async Task<Charity> UpdateCharityAsync(int id, Charity charity)
    {
      return await _giveHubCharityRepository.UpdateCharityAsync(id, charity);
    }

    public async Task<Charity> DeleteCharityAsync(int id)
    {
      return await _giveHubCharityRepository.DeleteCharityAsync(id);
    }
    // example

    // public async Task<List<Author>> GetAllAuthorsAsync()
    // {
    //   return await _simplyBooksAuthorRepository.GetAllAuthorsAsync();
    // }
  }
}
