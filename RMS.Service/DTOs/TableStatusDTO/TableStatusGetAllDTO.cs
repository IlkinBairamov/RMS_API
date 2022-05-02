using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.TableStatusDTO
{
    public class TableStatusGetAllDTO<TEntity>
    {
        public List<TEntity> TableStatuses { get; set; }
        public int Count { get; set; }
    }
}
