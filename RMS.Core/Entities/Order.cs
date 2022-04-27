using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    public class Order : BaseEntity
    {
        public int TableId { get; set; }
        public Table Table { get; set; }
        public ICollection<FoodOrder> FoodOrders { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public int OrderTypeId { get; set; }
        public OrderType OrderType { get; set; }
    }
}
