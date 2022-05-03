using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.CategoryDTO
{
    public class CategoryGetAllDTO<TEntity>
    {
        public List<TEntity> Categories { get; set; }   
        public int Count { get; set; }
    }
}
