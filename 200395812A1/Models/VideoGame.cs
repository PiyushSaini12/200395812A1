using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200395812A1.Models
{
    public class VideoGame
    {
        [Key]
        public int gameId { get; set; }

        [Display(Name = "Price")]
        public int Price { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "MinimumRequirements")]
        public string MinimumRequirements { get; set; }

        [Display(Name = "publisher")]
        [Required]
        public string Publisher{ get; set; }

        [Required]
        [Display(Name = "Developer")]
        public string Developer { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Display(Name = "Review")]
        public string Review { get; set; }

        /*  [Display(Name = "Website")]
        public string Website { get; set; }

        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Display(Name = "Stars")]
        public string Stars { get; set; }*/

    }
}