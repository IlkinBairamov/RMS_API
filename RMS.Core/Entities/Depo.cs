using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    public class Depo : BaseEntity
    {
        public string Name { get; set; }
        public decimal Dept { get; set; }
        public ICollection<ProductDepo> ProductDepos { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
    }
}
