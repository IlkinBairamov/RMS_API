using Microsoft.EntityFrameworkCore;
using RMS.Core.Entities;
using RMS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data.Repositories
{
    internal class ReservationRepository : Repository<Reservation>,IReservationRepository
    {
        private readonly AppDbContext _context;

        public ReservationRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> IsReservedAsync(int tableId)
        {
            var reservation = _context.Reservations.Where(x => x.TableId == tableId && x.IsDeleted==false).OrderBy(x=>x.Time).FirstOrDefault();
            DateTime currentTime = DateTime.UtcNow.AddHours(4);
            bool isReserved = false;
            var span = (reservation.Time - currentTime);
            double total = (double)span.TotalMilliseconds / 60 / 60 / 1000;

            if (total <= 1.1)
            {
                isReserved = true;
            }
            return isReserved;
        }
    }
}
