using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    public class Table : BaseEntity
    {
        public int Number { get; set; }
        public int AmountOfSeat { get; set; }
        public int Deposite { get; set; }
        public bool HasDeposite { get; set; }
        public bool? Status { get; set; }
        public int HallId { get; set; }
        public Hall Hall { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
