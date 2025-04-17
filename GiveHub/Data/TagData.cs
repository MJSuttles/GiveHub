using GiveHub.Models;

namespace GiveHub.Data
{
  public class TagData
  {
    public static List<Tag> Tags = new()
    {
      new Tag() { Id = 1, Name = "Education" },
      new Tag() { Id = 2, Name = "Environment" },
      new Tag() { Id = 3, Name = "Food Security" },
      new Tag() { Id = 4, Name = "Healthcare" },
      new Tag() { Id = 5, Name = "Youth Empowerment" }
    };
  }
}
