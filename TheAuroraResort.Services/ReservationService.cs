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
                    PartySize = model.PartySize,
                    ReservationDateTime = model.ReservationDateTime
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Reservations.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ReservationListItem> GetReservations()
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
                            CreatedUtc = e.CreatedUtc,
                            PartySize = e.PartySize,
                            ReservationDateTime = e.ReservationDateTime
                        }
                   );
                return query.ToArray();
            }
        }

        public ReservationDetail GetReservationById(int ReservationId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Reservations
                        .Single(e => e.ReservationId == ReservationId && e.UserId == _userId);
                return
                    new ReservationDetail
                    {
                        ReservationId = entity.ReservationId,
                        PartySize = entity.PartySize,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }

        public bool UpdateReservation(ReservationEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Reservations
                        .Single(e => e.ReservationId == model.ReservationId && e.UserId == _userId);

                entity.PartySize = model.PartySize;
                entity.ReservationDateTime = model.ReservationDateTime;
                entity.ModifiedUtc = DateTimeOffset.Now;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteReservation(int ReservationId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Reservations
                    .Single(e => e.ReservationId == ReservationId && e.UserId == _userId);

                ctx.Reservations.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
