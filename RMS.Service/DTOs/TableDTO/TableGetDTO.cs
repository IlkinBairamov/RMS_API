using RMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.TableDTO
{
    public class TableGetDTO
    {
        public int Number { get; set; }
        public int AmountOfSeat { get; set; }
        public int? Deposite { get; set; }
        public bool HasDeposite { get; set; }
        public string Status { get; set; }
        public string HallName { get; set; }
    }
}
