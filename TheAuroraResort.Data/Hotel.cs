using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAuroraResort.Data
{
    public class Hotel
    {
        public int NumberOfRoomsAvailable { get; set; }

        public Guid AdminId { get; set; }

        [Key]
        public int HotelId { get; set; }

        public IList<int> RoomList { get; set; }

    }
}
