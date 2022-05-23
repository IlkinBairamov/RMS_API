using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    public class Reservation:BaseEntity
    {
        public int TableId { get; set; }
        public string ClientName { get; set; }
        public Table Table { get; set; }
        public DateTime Time { get; set; }
    }
}
