using GiveHub.Models;

namespace GiveHub.Data
{
  public class EventData
  {
    public static List<Event> Events = new()
    {
      // seed sample data

      // example

      // new() { Id = 1, FirstName = "Lena", LastName = "Marquez", Email = "lena.marquez@example.com", Image = "https://example.com/images/lena.jpg", Favorite = true, UserId = 1 },
      new Event() { Id = 1, CharityId = 1, Name = "Back-to-School Drive", UserUid = "uid-hope1", Image = "https://example.com/images/schooldrive.jpg", Description = "Providing school supplies to children in need.", Street = "123 Unity Lane", City = "Springfield", State = "IL", Zip = "62704", ContactName = "Alice Johnson", ContactEmail = "alice@hopeforall.org", ContactPhone = "555-123-4567", Date = DateTime.Parse("2025-08-10T10:00:00") },
      new Event() { Id = 2, CharityId = 2, Name = "Tree Planting Day", UserUid = "uid-earth2", Image = "https://example.com/images/trees.jpg", Description = "Community tree planting initiative.", Street = "45 Nature Ave", City = "Boulder", State = "CO", Zip = "80301", ContactName = "Brian Meadows", ContactEmail = "brian@greenearth.org", ContactPhone = "555-765-4321", Date = DateTime.Parse("2025-04-22T09:00:00") },
      new Event() { Id = 3, CharityId = 3, Name = "Food Distribution Weekend", UserUid = "uid-food3", Image = "https://example.com/images/food.jpg", Description = "Volunteers needed for distributing donated food.", Street = "88 Kindness Blvd", City = "Portland", State = "OR", Zip = "97201", ContactName = "Catherine Lee", ContactEmail = "catherine@foodforward.org", ContactPhone = "555-789-0000", Date = DateTime.Parse("2025-05-15T13:30:00") },
      new Event() { Id = 4, CharityId = 4, Name = "Read-a-Thon Fundraiser", UserUid = "uid-books4", Image = "https://example.com/images/readathon.jpg", Description = "Raising funds by reading books for donations.", Street = "212 Literacy Ln", City = "Austin", State = "TX", Zip = "73301", ContactName = "David Chen", ContactEmail = "david@booksforkids.org", ContactPhone = "555-321-7890", Date = DateTime.Parse("2025-06-12T15:00:00") },
      new Event() { Id = 5, CharityId = 5, Name = "Homeless Outreach Day", UserUid = "uid-safe5", Image = "https://example.com/images/outreach.jpg", Description = "Connecting homeless individuals with resources.", Street = "678 Hope St", City = "Phoenix", State = "AZ", Zip = "85001", ContactName = "Erika Martinez", ContactEmail = "erika@safehaven.org", ContactPhone = "555-456-9999", Date = DateTime.Parse("2025-07-03T11:00:00") }
    };
  }
}
