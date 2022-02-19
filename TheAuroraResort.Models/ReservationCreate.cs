using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheAuroraResort.Models
{
    public class ReservationCreate
    {
        public int PartySize { get; set; }
        public string UserEmail { get; set; }
        public string UserName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ArrivalDateTime { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public string ActivityName { get; set; }

        public string ArrivalDate => ArrivalDateTime.ToString("MM/dd/yyyy");
        public string ArrivalTime => ArrivalDateTime.ToString("hh:mm tt");
        public string DepartureDate => DepartureDateTime.ToString("MM/dd/yyyy");
        public string DepartureTime => DepartureDateTime.ToString("hh:mm tt");
    }
}
