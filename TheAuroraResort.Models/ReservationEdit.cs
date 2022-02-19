using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [DataType(DataType.DateTime)]
        public DateTime ReservationDateTime { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
