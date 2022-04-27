using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    public class PaymentType : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Payment> Payments { get; set; }

    }
}
