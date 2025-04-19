using Microsoft.EntityFrameworkCore;
using GiveHub.Data;
using GiveHub.Interfaces;
using GiveHub.Models;

namespace GiveHub.Repositories
{
  public class GiveHubCharityTagRepository : IGiveHubCharityTagRepository
  {
    // The repository layer is responsible for CRUD operations.
    // This repository class implements the IWeatherForecastRepository interface.
    // Remember: the interface is a contract that defines methods that a class MUST implement.
    // The repository layer will call the database context to do the actual CRUD operations.
    // The repository layer will return the data to the service layer.

    private readonly GiveHubDbContext _context;

    public GiveHubCharityTagRepository(GiveHubDbContext context)
    {
      _context = context;
    }

    public async Task<CharityTag> CreateCharityTagAsync(CharityTag charityTag)
    {
      _context.CharityTags.Add(charityTag);
      await _context.SaveChangesAsync();
      return charityTag;
    }

    
    // seed data

    // examples

    // Get authors
    // public async Task<List<Author>> GetAllAuthorsAsync()
    // {
    //   return await _context.Authors.ToListAsync();
    // }

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
