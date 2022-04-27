using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    public class Staff : BaseEntity
    {
        public string FullName { get; set; }
        public int StaffTypeId { get; set; }
        public StaffType StaffType { get; set; }
        public decimal Salary { get; set; }
        public string PhoneNumber { get; set; }
        public int Pin { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
