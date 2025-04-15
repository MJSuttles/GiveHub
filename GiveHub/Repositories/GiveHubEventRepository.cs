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
  }
}
