using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    public class Hall : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Table> Tables { get; set; }
    }
}
