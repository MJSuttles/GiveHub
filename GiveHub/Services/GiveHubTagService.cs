using GiveHub.Interfaces;
using GiveHub.Models;
using GiveHub.Repositories;

namespace GiveHub.Services
{
  public class GiveHubTagService : IGiveHubTagService
  {
    private readonly IGiveHubTagRepository _giveHubTagRepository;

    public GiveHubTagService(IGiveHubTagRepository giveHubTagRepository)
    {
      _giveHubTagRepository = giveHubTagRepository;
    }

    // seed data

    // example

    // public async Task<List<Author>> GetAllAuthorsAsync()
    // {
    //   return await _simplyBooksAuthorRepository.GetAllAuthorsAsync();
    // }
  }
}
