using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAuroraResort.Data
{
    public class Rooms
    {
        public enum RoomType { BohoBoutique, Modern, ExtendedStay, Loft}

        [Key]
        public int RoomId  { get; set; }

        public int MyProperty { get; set; }

        public int NumberOfBeds { get; set; }

        public enum RoomView { BeachView, CityView }
        public DateTimeOffset CheckInDate { get; set; }
        public DateTimeOffset CheckOutDate { get; set; }
        public int RoomNumber  { get; set; }
        public int RoomFloor { get; set; }


        public virtual int HotelId { get; set; }


    }
}
