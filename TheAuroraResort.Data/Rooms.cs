using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Display(Name = "Hotel")]
        public int HotelId { get; set; }

        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }

    }


}

