using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAuroraResort.Data
{
    public class Activity
    {
        public int Price { get; set; }
        public virtual int ReservationId { get; set; }
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string Description { get; set; }
        public bool ReservationRequired { get;}
        public IList<string> Reservation { get; set; }

        [Display(Name = "Hotel")]
        public int HotelId { get; set; }

        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }

    }
}

