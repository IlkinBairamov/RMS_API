using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    class Purchase : BaseEntity
    {
        public int ProductId { get; set; }
        public int DepoId { get; set; }
        public Product Product { get; set; }
        public Depo Depo { get; set; }
        public DateTime Date { get; set; }
    }
}
