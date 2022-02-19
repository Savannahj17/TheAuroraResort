using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheAuroraResort.Data
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        public string ActivityName { get; set; }

        public Guid UserId { get; set; }

        [Required]
        public virtual int ProfileId { get;  set; }

        [Required]
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public string ArrivalDate { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureDate { get; set; }
        public string DepartureTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }

        public DateTime DepartureDateTime { get; set; }


        [Required]
        public int PartySize { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }

    
}

