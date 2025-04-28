using GiveHub.Models;

namespace GiveHub.Interfaces
{
  public interface IGiveHubCharityService
  {
    // An interface is a contract that defines the signature of the functionality.
    // It defines a set of methods that a class that inherits the interface MUST implement.
    // The interface is a mechanism to achieve abstraction.
    // Interfaces can be used in unit testing to mock out the actual implementation.

    // seed categories
    Task<List<Charity>> GetAllCharitiesAsync();
    Task<Charity?> GetCharityByIdAsync(int id);
    Task<List<Charity?>> GetCharityByUidAsync(string uid);
    Task<Charity> CreateCharityAsync(Charity charity);
    Task<Charity> UpdateCharityAsync(int id, Charity charity);
    Task<Charity> DeleteCharityAsync(int id);
    Task<List<Charity>> SearchCharitiesByNameAsync(string searchCharities);
  }
}
