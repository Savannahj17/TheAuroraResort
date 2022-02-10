using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAuroraResort.Models
{
    public class ReservationCreate
    {
        public enum ReservationTime { get; }
        public int MyProperty { get; set; }
        public int PartySize { get; set; }
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public IList<string> Reservations { get; set; }
    }
}
