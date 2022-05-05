using RMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.StaffTypeDTO
{
    public class StaffTypeGetDTO
    {
        public string Name { get; set; }
        public List<Staff> Staffs { get; set; }
    }
}
