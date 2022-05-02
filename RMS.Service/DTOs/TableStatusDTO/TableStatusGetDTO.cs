using RMS.Core.Entities;
using RMS.Service.DTOs.TableDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.TableStatusDTO
{
    public class TableStatusGetDTO
    {
        public string Status { get; set; }
        public List<TableGetDTO> Tables { get; set; }
    }
}
