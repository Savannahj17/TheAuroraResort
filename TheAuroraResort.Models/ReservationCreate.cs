using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAuroraResort.Models
{
    public class ReservationCreate
    {
        public int PartySize { get; set; }
        public string UserEmail { get; set; }
        public string UserName { get; set; }

        public DateTime ReservationDateTime { get; set; }
        public string ActivityName { get; set; }
    }
}
