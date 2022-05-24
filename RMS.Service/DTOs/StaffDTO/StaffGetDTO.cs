using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.StaffDTO
{
    public class StaffGetDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string StaffType { get; set; }
        public decimal Salary { get; set; }
        public string PhoneNumber { get; set; }
    }
}
