using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAuroraResort.Data
{
    public class UserProfile
    {
        [Required]
        public string UserEmail { get; set; }
        
        public Guid UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Key]
        public int ProfileId { get; set; }

        public bool IsMember { get; set; }

        [Display(Name="Hotel")]
        public int HotelId { get; set; }

        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }

    }
}
