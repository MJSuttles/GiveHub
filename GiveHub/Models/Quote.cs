using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GiveHub.Models
{
  public class Quote
  {
    public int Id { get; set; }
    public string Sentence { get; set; }
  }
}
