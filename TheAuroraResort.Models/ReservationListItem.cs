using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheAuroraResort.Models
{
    public class ReservationListItem
    {
        [ForeignKey("UserProfile")]
        public virtual int UserId { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        public int ReservationId { get; set; }
        public int PartySize { get; set; }
        public string ArrivalDate { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureDate { get; set; }
        public string DepartureTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ArrivalDateTime { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public string ActivityName { get; set; }
    }
}
