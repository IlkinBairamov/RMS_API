using FluentValidation;
using RMS.Service.DTOs.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.ProductTypeDTO
{
    public class ProductTypePostDTO
    {
        public string Name { get; set; }
    }

    public class ProductTypePostDTOValidator : AbstractValidator<ProductPostDTO>
    {
        public ProductTypePostDTOValidator()
        {
            RuleFor(x => x.Name).MaximumLength(2).MaximumLength(50).NotNull();
        }
    }
}
