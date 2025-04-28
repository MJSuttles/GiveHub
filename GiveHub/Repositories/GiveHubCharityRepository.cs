using Microsoft.EntityFrameworkCore;
using GiveHub.Data;
using GiveHub.Interfaces;
using GiveHub.Models;

namespace GiveHub.Repositories
{
  public class GiveHubCharityRepository : IGiveHubCharityRepository
  {
    // The repository layer is responsible for CRUD operations.
    // This repository class implements the IWeatherForecastRepository interface.
    // Remember: the interface is a contract that defines methods that a class MUST implement.
    // The repository layer will call the database context to do the actual CRUD operations.
    // The repository layer will return the data to the service layer.

    private readonly GiveHubDbContext _context;

    public GiveHubCharityRepository(GiveHubDbContext context)
    {
      _context = context;
    }

    // seed data
    public async Task<List<Charity>> GetAllCharitiesAsync()
    {
      return await _context.Charities
          .Include(e => e.Events)
          .Include(c => c.CharityTags)
          .ThenInclude(ct => ct.Tag)
          .ToListAsync();
    }

    public async Task<Charity?> GetCharityByIdAsync(int id)
    {
      return await _context.Charities
      .Include(e => e.Events)
      .Include(c => c.CharityTags)
      .ThenInclude(ct => ct.Tag)
      .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<List<Charity?>> GetCharityByUidAsync(string uid)
    {
      return await _context.Charities
      .Where(c => c.UserUid == uid)
        .Include(e => e.Events)
        .Include(c => c.CharityTags)
        .ThenInclude(ct => ct.Tag)
        .ToListAsync();
    }

    public async Task<Charity> CreateCharityAsync(Charity charity)
    {
      _context.Charities.Add(charity);
      await _context.SaveChangesAsync();
      return charity;
    }

    public async Task<Charity> UpdateCharityAsync(int id, Charity charity)
    {
      var existingCharity = await _context.Charities.FindAsync(id);
      if (existingCharity == null)
      {
        return null;
      }
      existingCharity.Name = charity.Name;
      existingCharity.Description = charity.Description;
      existingCharity.Owners = charity.Owners;
      existingCharity.Image = charity.Image;
      existingCharity.Website = charity.Website;
      existingCharity.UserUid = charity.UserUid;

      await _context.SaveChangesAsync();
      return charity;
    }

    public async Task<Charity> DeleteCharityAsync(int id)
    {
      var charity = await _context.Charities.FindAsync(id);
      if (charity != null)
      {
        _context.Charities.Remove(charity);
        await _context.SaveChangesAsync();
        return charity;
      }
      return null;
    }

    public async Task<List<Charity>> SearchCharitiesByNameAsync(string searchCharities)
    {
      return await _context.Charities
        .Where(c => c.Name.ToLower().Contains(searchCharities.ToLower()))
        .Include(e => e.Events)
        .Include(c => c.CharityTags)
        .ThenInclude(ct => ct.Tag)
        .ToListAsync();
    }


  }
}
