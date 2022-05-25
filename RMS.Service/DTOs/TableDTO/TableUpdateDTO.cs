using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.TableDTO
{
    public class TableUpdateDTO
    {
        public int Number { get; set; }
        public int AmountOfSeat { get; set; }
        public int? Deposite { get; set; }
        public bool HasDeposite { get; set; }
        public int HallId { get; set; }
    }
}
