using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAuroraResort.Data;
using TheAuroraResort.Models;

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
            var entity =
                new Reservation()
                {
                    UserId = _userId,
                    UserEmail = model.UserEmail,
                    PartySize = model.PartySize

                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Reservations.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnuemerable<ReservationListItem> GetReservations()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Reservations
                    .Where(e => e.UserId == _userId)
                    .Select(
                        e =>
                        new ReservationListItem
                        {
                            ReservationId = e.ReservationId,
                            
                        }
                   );
            }
        }
    }
}
