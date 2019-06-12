using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200395812A1.Models
{
    public class Reviews
    {
        [Key]
        [Required]
        public int ReviewId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Review { get; set; }
        [Range(1, 5)]
        public int NumberOfStars { get; set; }
    }
}