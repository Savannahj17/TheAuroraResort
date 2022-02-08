using System;
using System.Collections.Generic;
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
        public int HotelId { get; set; }
        public IList<string> reservation { get; set; }

    }
}
