using GiveHub.Models;

namespace GiveHub.Interfaces
{
  public interface IGiveHubCharityTagRepository
  {
    // An interface is a contract that defines the signature of the functionality.
    // It defines a set of methods that a class that inherits the interface MUST implement.
    // The interface is a mechanism to achieve abstraction.
    // Interfaces can be used in unit testing to mock out the actual implementation.

    // seed categories

    // example
    // Task<List<Author>> GetAllAuthorsAsync();
    Task<CharityTag> CreateCharityTagAsync(CharityTag charityTag);
    Task<bool> DeleteCharityTagAsync(int charityId, int tagId);
    Task DeleteAllCharityTagsByCharityIdAsync(int charityId);
  }
}
