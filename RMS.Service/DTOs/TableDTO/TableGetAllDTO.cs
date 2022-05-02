using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.TableDTO
{
    public class TableGetAllDTO
    {
        public List<TableGetDTO> Tables { get; set; }
        public int Count { get; set; }
    }
}
