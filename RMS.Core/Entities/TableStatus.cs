using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    public class TableStatus:BaseEntity
    {
        public string Status { get; set; }
        public ICollection<Table> Tables { get; set; }  
    }
}
