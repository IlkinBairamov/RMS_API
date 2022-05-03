using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.OrderDTO
{
    public class OrderFoodGetDTO
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}
