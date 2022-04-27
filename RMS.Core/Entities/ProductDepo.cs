using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    class ProductDepo : BaseEntity
    {
        public int DepoId { get; set; }
        public Depo Depo { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
