using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    public class FoodProduct :BaseEntity
    {
        public int ProductId { get; set; }
        public int FoodId { get; set; }
        public Product Product { get; set; }
        public Food Food { get; set; }

    }
}
