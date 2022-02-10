using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAuroraResort.Services
{
    public class ReservationService
    {
        private readonly Guid _userId;

        public ReservationService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateReservation(ReservationCreate model)
        {

        }
    }
}
