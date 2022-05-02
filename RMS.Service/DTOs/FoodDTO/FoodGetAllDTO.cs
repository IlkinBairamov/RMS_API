using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.FoodDTO
{
    public class FoodGetAllDTO<TEntity>
    {
        public List<TEntity> Foods { get; set; }
        public int Count { get; set; }
    }
}
