using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    class OrderType :BaseEntity
    {
        public int Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
