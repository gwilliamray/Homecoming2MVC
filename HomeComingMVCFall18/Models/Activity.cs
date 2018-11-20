using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeComingMVCFall18.Models
{
    [Table("Activity")]
    public class Activity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        [MaxLength(255)]
        public string  Location { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name ="Event Date")]
        public DateTime ActivityDate { get; set; }

        [MaxLength(2048)]
        public string Note { get; set; }

        [Required]
        [Range(0, 99.99)]
        public Decimal Cost { get; set; }

        public Venue Venue { get; set; }
        public int VenueId { get; set; }
    }
}