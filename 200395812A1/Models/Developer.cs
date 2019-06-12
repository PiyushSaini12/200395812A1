using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200395812A1.Models
{
    public class Developer
    {
        [Key]
        [Required]
        public int DeveloperId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Website { get; set; }
    }
}