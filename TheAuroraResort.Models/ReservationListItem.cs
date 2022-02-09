using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAuroraResort.Models
{
    public class ReservationListItem
    {
        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        public int ReservationId { get; set; }
        public DateTimeOffset ReservationDate { get;}
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
    }
}
