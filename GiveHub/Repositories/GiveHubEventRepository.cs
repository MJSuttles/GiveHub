using Microsoft.EntityFrameworkCore;
using GiveHub.Data;
using GiveHub.Interfaces;
using GiveHub.Models;

namespace GiveHub.Repositories
{
  public class GiveHubEventRepository : IGiveHubEventRepository
  {
    // The repository layer is responsible for CRUD operations.
    // This repository class implements the IWeatherForecastRepository interface.
    // Remember: the interface is a contract that defines methods that a class MUST implement.
    // The repository layer will call the database context to do the actual CRUD operations.
    // The repository layer will return the data to the service layer.

    private readonly GiveHubDbContext _context;

    public GiveHubEventRepository(GiveHubDbContext context)
    {
      _context = context;
    }

    // seed data

  public async Task<List<Event>> GetEventsByCharityIdAsync(int charityId)
  {
  return await _context.Events
    .Where(e => e.CharityId == charityId)
    .Include(e => e.Charity)
    .ThenInclude(c => c.CharityTags)
    .ToListAsync();
  }

    public async Task<Event> CreateEventAsync(Event eventEntity)
    {
      _context.Events.Add(eventEntity);
      await _context.SaveChangesAsync();
      return eventEntity;
    }

    public async Task<Event> UpdateEventAsync(int id, Event eventEntity)
    {
      var existingEvent = await _context.Events.FindAsync(id);
      if (existingEvent == null)
      {
        return null;
      }

      existingEvent.Name = eventEntity.Name;
      existingEvent.Description = eventEntity.Description;
      existingEvent.Date = eventEntity.Date;
      existingEvent.Street = eventEntity.Street;
      existingEvent.City = eventEntity.City;
      existingEvent.State = eventEntity.State;
      existingEvent.Zip = eventEntity.Zip;

      await _context.SaveChangesAsync();
      return existingEvent;
    }

    public async Task<Event> DeleteEventAsync(int id)
    {
      var existingEvent = await _context.Events.FindAsync(id);
      if (existingEvent == null)
      {
        return null;
      }

      _context.Events.Remove(existingEvent);
      await _context.SaveChangesAsync();
      return existingEvent;
    }
  }
}
