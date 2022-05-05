using RMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Repositories
{

    public interface IReservationRepository : IRepository<Reservation>
    {
        Task<bool> IsReservedAsync(int tableId);
        Task<bool> HasReservedAsync(int tableId,DateTime time);
    }
}
