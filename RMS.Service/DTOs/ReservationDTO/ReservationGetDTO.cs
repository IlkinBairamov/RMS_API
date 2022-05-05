using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.ReservationDTO
{
    public class ReservationGetDTO
    {
        public int TableNumber { get; set; }
        public DateTime Time { get; set; }
    }
}
