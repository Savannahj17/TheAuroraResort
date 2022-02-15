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

        //public enum ReservationTime { 8am = 1, 9, 10 }

        public enum ActivityName { WaterPark = 1, ZipLining, WaterSkiing, LiveShow }

        public Guid UserId { get; set; }

        [Required]
        public virtual int ProfileId { get;  set; }

        [Required]
        public string UserEmail { get; set; }
        public DateTime ReservationDate { get; set; }

        //DateTimePicker
        //edit models
        //display name
        //
        //Store as one variable
        //
        public virtual int RestaurantId { get; set; }
        public int ActivityId { get; set; }

        [Required]
        public int PartySize { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}

