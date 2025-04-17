using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GiveHub.Models
{
    public class CharityTag
    {
        public int CharityId { get; set; }
        [Required]
        public Charity Charity { get; set; }
        public int TagId { get; set; }
        [Required]
        public Tag Tag { get; set; }
    }
}
