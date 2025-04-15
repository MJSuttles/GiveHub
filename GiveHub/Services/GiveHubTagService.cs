using GiveHub.Interfaces;
using GiveHub.Models;
using GiveHub.Repositories;

namespace SimplyBooks.Services
{
  public class GiveHubTagService : IGiveHubTagService
  {
    private readonly IGiveHubTagRepository _giveHubTagRepository;

    public GiveHubTagService(IGiveHubTagRepository giveHubTagRepository)
    {
      _giveHubTagRepository = giveHubTagRepository;
    }

    // seed data
  }
}
