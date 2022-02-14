using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAuroraResort.Data
{
    public class Restaurant
    {
        public string RestaurantName { get; set; }

        public enum TypeOfDining { Formal, Casual, Buffet }
        public bool ReservationRequired { get; }
        public IList<string> Reservation { get; set; }

        [Display(Name = "Hotel")]
        public int HotelId { get; set; }

        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }

    }

}
