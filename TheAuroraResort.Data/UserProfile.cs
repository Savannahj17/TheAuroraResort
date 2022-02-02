using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAuroraResort.Data
{
    public class UserProfile
    {
        public string UserEmail { get; set; }

        public Guid UserId { get; set; }

        public string UserName { get; set; }

        public IList<string> Reservations { get; set; }

        [Key]
        public int ProfileId { get; set; }

        public bool IsMember { get; set; }

        public int MyProperty { get; set; }
    }
}
