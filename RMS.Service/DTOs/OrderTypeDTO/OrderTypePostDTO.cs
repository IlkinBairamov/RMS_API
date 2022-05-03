using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.OrderTypeDTO
{
    public class OrderTypePostDTO
    {
        public string Name { get; set; }
    }
    public class OrderTypePostDTOValidator : AbstractValidator<OrderTypePostDTO>
    {
        public OrderTypePostDTOValidator()
        {
            RuleFor(x => x.Name).MinimumLength(2).MaximumLength(50);
        }
    }
}
