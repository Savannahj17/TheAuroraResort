using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheAuroraResort.Models
{
    public class ReservationEdit
    {
        [ForeignKey("UserProfile")]
        public virtual int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public int ReservationId { get; set; }

        public int PartySize { get; set; }
       
        public string ArrivalDate { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureDate { get; set; }
        public string DepartureTime { get; set; }

        public string ActivityName { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ArrivalDateTime => DateTime.ParseExact($"{ArrivalDate } {ArrivalTime }", "MM/dd/yyyy hh:mm tt", CultureInfo.GetCultureInfo("en-US"));
        public DateTime DepartureDateTime => DateTime.ParseExact($"{DepartureDate } {DepartureTime }", "MM/dd/yyyy hh:mm tt", CultureInfo.GetCultureInfo("en-US"));


    }
}
