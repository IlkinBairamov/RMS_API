using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.OrderDTO
{
    public class OrderGetAllDTO<TEntity>
    {
        public List<TEntity> Orders { get; set; }
        public int Count { get; set; }
    }
}
