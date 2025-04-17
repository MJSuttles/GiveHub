using GiveHub.Models;

namespace GiveHub.Interfaces
{
  public interface IGiveHubEventRepository
  {
    // An interface is a contract that defines the signature of the functionality.
    // It defines a set of methods that a class that inherits the interface MUST implement.
    // The interface is a mechanism to achieve abstraction.
    // Interfaces can be used in unit testing to mock out the actual implementation.

    // seed categories
    Task<List<Event>> GetEventsByCharityIdAsync(int charityId);
    Task<Event> CreateEventAsync(Event eventEntity);
    Task<Event> UpdateEventAsync(int id, Event eventEntity);
    Task<Event> DeleteEventAsync(int id);
  }
}
