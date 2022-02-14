using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAuroraResort.Data
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        public enum ReservationTime { Morning = 1, Afternon, Evening, Night }

        public Guid UserId { get; set; }

        [Required]
        public virtual int ProfileId { get;  set; }

        [Required]
        public string UserEmail { get; set; }
        public virtual int RestaurantId { get; set; }
        public int ActivityId { get; set; }

        [Required]
        public int PartySize { get; set; }

    }
}
