using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.ProductDTO
{
    public class ProductGetAllDTO<TEntity>
    {
        public List<TEntity> Products { get; set; }
        public int Count { get; set; }
    }
}
