using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GiveHub.Models
{
  public class Charity
  {
    public int Id { get; set; }
    public string UserUid { get; set; }

    [Required]
    public string Name { get; set; }

    public string Owners { get; set; } // Fixed property name

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

    public string Website { get; set; }

    public decimal Donations { get; set; }

    public int Stars { get; set; }

    // Navigation properties
    public List<CharityTag> CharityTags { get; set; }

    public List<Event>? Events { get; set; }
  }
}
