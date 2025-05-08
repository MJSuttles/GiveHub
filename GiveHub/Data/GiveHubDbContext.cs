using Microsoft.EntityFrameworkCore;
using GiveHub.Models;

namespace GiveHub.Data
{
  public class GiveHubDbContext : DbContext
  {
    public DbSet<Charity> Charities { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<CharityTag> CharityTags { get; set; }
    public DbSet<Quote> Quotes { get; set; }
    

    public GiveHubDbContext(DbContextOptions<GiveHubDbContext> context) : base(context) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

      modelBuilder.Entity<CharityTag>()
      .HasKey(ct => new { ct.CharityId, ct.TagId });

      modelBuilder.Entity<CharityTag>()
      .HasOne(ct => ct.Charity)
      .WithMany(c => c.CharityTags)
      .HasForeignKey(ct => ct.CharityId);

      modelBuilder.Entity<CharityTag>()
      .HasOne(ct => ct.Tag)
      .WithMany(t => t.CharityTags)
      .HasForeignKey(ct => ct.TagId);

      modelBuilder.Entity<Charity>().HasData(CharityData.Charities);
      modelBuilder.Entity<Event>().HasData(EventData.Events);
      modelBuilder.Entity<Tag>().HasData(TagData.Tags);
      modelBuilder.Entity<CharityTag>().HasData(CharityTagData.CharityTags);
      modelBuilder.Entity<Quote>().HasData(QuoteData.Quotes);
    }
  }
}
