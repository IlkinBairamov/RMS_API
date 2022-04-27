using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    class Food :BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<FoodProduct> FoodProducts { get; set; }
        public ICollection<FoodOrder> FoodOrders { get; set; }
    }
}
