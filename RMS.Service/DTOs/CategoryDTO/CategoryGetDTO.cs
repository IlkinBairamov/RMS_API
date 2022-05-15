using RMS.Service.DTOs.FoodDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.CategoryDTO
{
    public class CategoryGetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FoodGetDTO> Foods { get; set; } 
    }
}
