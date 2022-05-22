using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.OrderDTO
{
    public class OrderGetDTO
    {
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public List<OrderFoodGetDTO> Foods { get; set; }
        public string StaffName { get; set; }
        public double TotalPrice { get; set; }
    }
}
