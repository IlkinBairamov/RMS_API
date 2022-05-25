using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMS.MVC.ViewModels.Table
{
    public class TableCreateVM
    {
        public int Number { get; set; }
        public int AmountOfSeat { get; set; }
        public int? Deposite { get; set; }
        public bool HasDeposite { get; set; }
        public int StatusId { get; set; }
        public int HallId { get; set; }
    }
}
