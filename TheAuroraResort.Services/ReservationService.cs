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
                    UserName = model.UserName,
                    UserEmail = model.UserEmail,
                    PartySize = model.PartySize,
                    ArrivalDateTime = model.ArrivalDateTime,
                    DepartureDateTime = model.DepartureDateTime,
                    ActivityName = model.ActivityName
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
                            ArrivalDateTime = e.ArrivalDateTime,
                            DepartureDateTime = e.ArrivalDateTime,
                            ActivityName = e.ActivityName
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
                        ModifiedUtc = entity.ModifiedUtc,
                        ArrivalDateTime = entity.ArrivalDateTime,
                        DepartureDateTime= entity.ArrivalDateTime,
                        ActivityName= entity.ActivityName
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

                entity.UserEmail = model.UserEmail;
                entity.UserName = model.UserName;
                entity.PartySize = model.PartySize;
                entity.ActivityName = model.ActivityName;
                entity.ArrivalDateTime = model.ArrivalDateTime;
                entity.DepartureDateTime = model.DepartureDateTime;
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
