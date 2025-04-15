using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiveHub.Models
{
  public class Event
  {
    public int Id { get; set; }
    public string UserUid { get; set; }

    [ForeignKey("Charity")]
    public int EventId { get; set; } // This is the CharityId

    [Required]
    public string Name { get; set; }

    public string Image { get; set; }

    public string Description { get; set; }

    public string Street { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Zip { get; set; }

    public string ContactName { get; set; }

    [EmailAddress]
    public string ContactEmail { get; set; }

    public string ContactPhone { get; set; }

    public DateTime Date { get; set; }

    // Navigation property
    public Charity Charity { get; set; }
  }
}
