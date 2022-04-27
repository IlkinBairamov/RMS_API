using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    class Receipt : BaseEntity
    {
        public int Barcode { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public Order Order { get; set; }
    }
}
