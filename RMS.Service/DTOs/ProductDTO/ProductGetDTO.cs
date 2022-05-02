using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.ProductDTO
{
    public class ProductGetDTO
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public decimal CostPrice { get; set; }
        public string ProductType { get; set; }
    }
}
