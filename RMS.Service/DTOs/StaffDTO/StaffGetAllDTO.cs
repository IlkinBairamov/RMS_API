using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.StaffDTO
{
    public class StaffGetAllDTO<TEntity>
    {
        public List<TEntity> Staffs { get; set; }
        public int Count { get; set; }
    }
}
