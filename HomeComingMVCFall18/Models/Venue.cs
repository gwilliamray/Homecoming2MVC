using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeComingMVCFall18.Models
{
    [Table("Venue")]
    public class Venue
    {
        public int Id { get; set; }
        public string  Setting { get; set; }

    }
}