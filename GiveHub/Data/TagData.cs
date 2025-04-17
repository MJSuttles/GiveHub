using GiveHub.Models;

namespace GiveHub.Data
{
  public class TagData
  {
    public static List<Tag> Tags = new()
    {
      // seed sample data

      // example

      // new() { Id = 1, FirstName = "Lena", LastName = "Marquez", Email = "lena.marquez@example.com", Image = "https://example.com/images/lena.jpg", Favorite = true, UserId = 1 },
      new Tag() { Id = 1, Name = "Education" },
      new Tag() { Id = 2, Name = "Environment" },
      new Tag() { Id = 3, Name = "Food Security" },
      new Tag() { Id = 4, Name = "Healthcare" },
      new Tag() { Id = 5, Name = "Youth Empowerment" }
    };
  }
}
