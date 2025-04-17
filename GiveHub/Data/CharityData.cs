using GiveHub.Models;

namespace GiveHub.Data
{
  public class CharityData
  {
    public static List<Charity> Charities = new()
    {
      new Charity() { Id = 1, Name = "Hope for All", UserUid = "uid-hope1", Owners = "Alice Johnson", Image = "https://example.com/images/hope.jpg", Description = "Helping underserved communities with education and shelter.", Street = "123 Unity Lane", City = "Springfield", State = "IL", Zip = "62704", ContactName = "Alice Johnson", ContactEmail = "alice@hopeforall.org", ContactPhone = "555-123-4567", Website = "https://hopeforall.org", Donations = 3500, Stars = 4 },
      new Charity() { Id = 2, Name = "Green Earth Fund", UserUid = "uid-earth2", Owners = "Brian Meadows", Image = "https://example.com/images/green.jpg", Description = "Promoting environmental sustainability and awareness.", Street = "45 Nature Ave", City = "Boulder", State = "CO", Zip = "80301", ContactName = "Brian Meadows", ContactEmail = "brian@greenearth.org", ContactPhone = "555-765-4321", Website = "https://greenearth.org", Donations = 8900, Stars = 5 },
      new Charity() { Id = 3, Name = "Food Forward", UserUid = "uid-food3", Owners = "Catherine Lee", Image = "https://example.com/images/foodforward.jpg", Description = "Connecting food donors with hunger relief programs.", Street = "88 Kindness Blvd", City = "Portland", State = "OR", Zip = "97201", ContactName = "Catherine Lee", ContactEmail = "catherine@foodforward.org", ContactPhone = "555-789-0000", Website = "https://foodforward.org", Donations = 12000, Stars = 5 },
      new Charity() { Id = 4, Name = "Books for Kids", UserUid = "uid-books4", Owners = "David Chen", Image = "https://example.com/images/books.jpg", Description = "Providing books and literacy programs for children.", Street = "212 Literacy Ln", City = "Austin", State = "TX", Zip = "73301", ContactName = "David Chen", ContactEmail = "david@booksforkids.org", ContactPhone = "555-321-7890", Website = "https://booksforkids.org", Donations = 5000, Stars = 4 },
      new Charity() { Id = 5, Name = "Safe Haven Shelter", UserUid = "uid-safe5", Owners = "Erika Martinez", Image = "https://example.com/images/shelter.jpg", Description = "Supporting homeless individuals with food and housing.", Street = "678 Hope St", City = "Phoenix", State = "AZ", Zip = "85001", ContactName = "Erika Martinez", ContactEmail = "erika@safehaven.org", ContactPhone = "555-456-9999", Website = "https://safehaven.org", Donations = 7400, Stars = 5 },

    };
  }
}
