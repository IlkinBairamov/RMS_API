using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    public class FoodOrder : BaseEntity
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public int FoodAmount { get; set; }
    }
}
