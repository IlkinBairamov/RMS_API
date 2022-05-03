using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.OrderDTO
{
    public class OrderEditDTO
    {
        public int TableNumber { get; set; }
        public List<OrderFoodGetDTO> Foods { get; set; }
        public int OrderTypeId { get; set; }
    }
}
