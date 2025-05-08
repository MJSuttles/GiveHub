using Microsoft.EntityFrameworkCore;
using GiveHub.Data;
using GiveHub.Interfaces;
using GiveHub.Models;

namespace GiveHub.Repositories
{
  public class GiveHubQuoteRepository : IGiveHubQuoteRepository
  {
    // The repository layer is responsible for CRUD operations.
    // This repository class implements the IWeatherForecastRepository interface.
    // Remember: the interface is a contract that defines methods that a class MUST implement.
    // The repository layer will call the database context to do the actual CRUD operations.
    // The repository layer will return the data to the service layer.

    private readonly GiveHubDbContext _context;

    public GiveHubQuoteRepository(GiveHubDbContext context)
    {
      _context = context;
    }

    // seed datapublic async Task<Quote> GetRandomQuoteAsync()
    public async Task<Quote> GetRandomQuoteAsync()
    {
        var count = await _context.Quotes.CountAsync(); // Get total count of quotes
        var randomIndex = new Random().Next(0, count); // Generate a random index
        var randomQuote = await _context.Quotes.Skip(randomIndex).FirstOrDefaultAsync(); // Get a random quote based on index
        
        return randomQuote;
    }

  }
}
