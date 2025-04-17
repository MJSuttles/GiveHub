using GiveHub.Models;

namespace GiveHub.Data
{
  public class EventData
  {
    public static List<Event> Events = new()
    {
      new Event() { Id = 1, CharityId = 1, Name = "Back-to-School Drive", UserUid = "uid-hope1", Image = "https://example.com/images/schooldrive.jpg", Description = "Providing school supplies to children in need.", Street = "123 Unity Lane", City = "Springfield", State = "IL", Zip = "62704", ContactName = "Alice Johnson", ContactEmail = "alice@hopeforall.org", ContactPhone = "555-123-4567", Date = new DateTime(2025, 5, 15, 13, 30, 0, DateTimeKind.Utc) },
      new Event() { Id = 2, CharityId = 2, Name = "Tree Planting Day", UserUid = "uid-earth2", Image = "https://example.com/images/trees.jpg", Description = "Community tree planting initiative.", Street = "45 Nature Ave", City = "Boulder", State = "CO", Zip = "80301", ContactName = "Brian Meadows", ContactEmail = "brian@greenearth.org", ContactPhone = "555-765-4321", Date = new DateTime(2025, 5, 15, 13, 30, 0, DateTimeKind.Utc) },
      new Event() { Id = 3, CharityId = 3, Name = "Food Distribution Weekend", UserUid = "uid-food3", Image = "https://example.com/images/food.jpg", Description = "Volunteers needed for distributing donated food.", Street = "88 Kindness Blvd", City = "Portland", State = "OR", Zip = "97201", ContactName = "Catherine Lee", ContactEmail = "catherine@foodforward.org", ContactPhone = "555-789-0000", Date = new DateTime(2025, 5, 15, 13, 30, 0, DateTimeKind.Utc) },
      new Event() { Id = 4, CharityId = 4, Name = "Read-a-Thon Fundraiser", UserUid = "uid-books4", Image = "https://example.com/images/readathon.jpg", Description = "Raising funds by reading books for donations.", Street = "212 Literacy Ln", City = "Austin", State = "TX", Zip = "73301", ContactName = "David Chen", ContactEmail = "david@booksforkids.org", ContactPhone = "555-321-7890", Date = new DateTime(2025, 5, 15, 13, 30, 0, DateTimeKind.Utc) },
      new Event() { Id = 5, CharityId = 5, Name = "Homeless Outreach Day", UserUid = "uid-safe5", Image = "https://example.com/images/outreach.jpg", Description = "Connecting homeless individuals with resources.", Street = "678 Hope St", City = "Phoenix", State = "AZ", Zip = "85001", ContactName = "Erika Martinez", ContactEmail = "erika@safehaven.org", ContactPhone = "555-456-9999", Date = new DateTime(2025, 5, 15, 13, 30, 0, DateTimeKind.Utc) }
    };
  }
}
