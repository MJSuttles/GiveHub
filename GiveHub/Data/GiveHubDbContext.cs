using Microsoft.EntityFrameworkCore;
using GiveHub.Models;

namespace GiveHub.Data
{
  public class GiveHubDbContext : DbContext
  {
    public DbSet<Charity> Charities { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Tag> Tags { get; set; }

    public GiveHubDbContext(DbContextOptions<GiveHubDbContext> context) : base(context) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Charity>().HasData(CharityData.Charities);
      modelBuilder.Entity<Event>().HasData(EventData.Events);
      // modelBuilder.Entity<Tag>().HasData(TagData.Tag);
    }
  }
}
