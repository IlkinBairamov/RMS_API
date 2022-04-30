using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.HallDTO
{
    public class HallGetAllDTO
    {
        public List<HallGetDTO> Halls { get; set; }
        public int Count { get; set; }
    }
}
