using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.ProductDTO
{
    public class ProductPostDTO
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public decimal CostPrice { get; set; }
        public int ProductTypeID { get; set; }
    }

    public class ProductPostDTOValidator : AbstractValidator<ProductPostDTO>
    {
        public ProductPostDTOValidator()
        {
            RuleFor(x => x.Name).MinimumLength(2).MaximumLength(50).NotNull();
            RuleFor(x => x.Amount).GreaterThanOrEqualTo(0).NotNull();
            RuleFor(x => x.CostPrice).GreaterThanOrEqualTo(0).NotNull();
            RuleFor(x => x.ProductTypeID).GreaterThanOrEqualTo(1).NotNull();
        }
    }
}
