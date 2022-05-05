using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.ReservationDTO
{
    public class ReservationGetAllDTO<TEntity>
    {
        public List<TEntity> Reservations { get; set; }
        public int Count { get; set; }

    }
}
