using GiveHub.Models;

namespace GiveHub.Data
{
  public class CharityTagData
  {
    public static List<CharityTag> CharityTags = new()
    {
        new CharityTag() { CharityId = 1, TagId = 1 },
        new CharityTag() { CharityId = 1, TagId = 5 },
        new CharityTag() { CharityId = 2, TagId = 2 },
        new CharityTag() { CharityId = 3, TagId = 3 }
    };
  }
}
