using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarEventWebApp.Models
{
    public class EventLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public double LocationLatitude { get; set; }
        public double LocationLongitude { get; set; }
        public ICollection<EventDetails> EventDetails { get; set; }
    }
}
