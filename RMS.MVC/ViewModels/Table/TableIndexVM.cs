using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMS.MVC.ViewModels.Table
{
    public class TableIndexVM
    {
        public List<TableIndexItemVM> Tables { get; set; }
        public int Count { get; set; }
    }

    public class TableIndexItemVM
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int AmountOfSeat { get; set; }
        public int? Deposite { get; set; }
        public bool HasDeposite { get; set; }
        public string Status { get; set; }
        public string HallName { get; set; }
        public int HallId { get; set; }
    }
}
