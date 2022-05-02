using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.ProductTypeDTO
{
    public class ProductTypeGetAllDTO<TEntity>
    {
        public List<TEntity> ProductTypes { get; set; }   
        public int Count { get; set; }
    }
}
