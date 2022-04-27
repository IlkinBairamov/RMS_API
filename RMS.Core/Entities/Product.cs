using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    public class Product :BaseEntity
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public decimal CostPrice { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public ICollection<ProductDepo> ProductDepos { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
        public ICollection<FoodProduct> FoodProducts { get; set; }
    }
}
