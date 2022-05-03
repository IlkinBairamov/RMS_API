using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.OrderTypeDTO
{
    public class OrderTypeGetAllDTO<TEntity>
    {
        public List<TEntity> OrderTypes { get; set; }  
        public int Count { get; set; }
    }
}
