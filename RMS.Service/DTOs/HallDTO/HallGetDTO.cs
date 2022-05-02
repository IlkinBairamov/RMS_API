using FluentValidation;
using RMS.Service.DTOs.TableDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.HallDTO
{
    public class HallGetDTO
    {
        public string Name { get; set; }
        public List<TableGetDTO> Tables { get; set; }
    }
}
