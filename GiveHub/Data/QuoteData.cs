using GiveHub.Models;

namespace GiveHub.Data
{
  public class QuoteData
  {
    public static List<Quote> Quotes = new()
    {
      new Quote() { Id = 1, Sentence = "The best way to find yourself is to lose yourself in the service of others." },
      new Quote() { Id = 2, Sentence = "Success is not the key to happiness. Happiness is the key to success." }
    };
  }
}
