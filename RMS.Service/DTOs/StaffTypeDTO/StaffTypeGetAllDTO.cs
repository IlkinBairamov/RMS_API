using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.StaffTypeDTO
{
    public class StaffTypeGetAllDTO<TEntity>
    {
        public List<TEntity> StaffTypes { get; set; }
        public int Count { get; set; }
    }
}
