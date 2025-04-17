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

    // examples

    // Get authors
    // public async Task<List<Author>> GetAllAuthorsAsync()
    // {
    //   return await _context.Authors.ToListAsync();
    // }

    public async Task<List<Charity>> GetAllCharitiesAsync()
    {
    return await _context.Charities             // load the related Events
        .Include(c => c.CharityTags)                // load the join entities…
          .ThenInclude(ct => ct.Tag)               // …and then the Tag on each join
        .ToListAsync();
    }

    public async Task<Charity> GetCharityByIdAsync(int id)
    {
        return await _context.Charities
        .Include(c => c.CharityTags)              // load the join‐entities
            .ThenInclude(ct => ct.Tag)            // and then each Tag
        .FirstOrDefaultAsync(c => c.Id == id);    // filter by your id
    }
    
    public async Task<Charity> GetCharityByUidAsync(string uid)
    {
      return await _context.Charities
        .Include(c => c.CharityTags)                // load the join entities…
        .ThenInclude(ct => ct.Tag)               // …and then the Tag on each join
        .FirstOrDefaultAsync(c => c.UserUid == uid);
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

    // // Get authors by user
    // public async Task<List<Author>> GetAuthorsByUserAsync(int userId)
    // {
    //   return await _context.Authors
    //           .Where(a => a.UserId == userId)
    //           .Include(a => a.Books)
    //           .ToListAsync();
    // }
  }
}
