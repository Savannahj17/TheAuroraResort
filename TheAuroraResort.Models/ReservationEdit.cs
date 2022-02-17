using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheAuroraResort.Models
{
    public class ReservationEdit
    {
        public int ReservationId { get; set; }

        public int PartySize { get; set; }

        public DateTimePicker ReservationDateTime { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
