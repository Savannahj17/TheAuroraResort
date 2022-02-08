using System;
using System.Collections.Generic;
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
        public string Description { get; set; }
        public bool ReservationRequired { get;}
        public IList<string> reservation { get; set; }
        public int HotelId { get; set; }
    }
}
