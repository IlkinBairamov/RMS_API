using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.ReceiptDTO
{
    public class ReceiptPostDTO
    {
        public int OrderId { get; set; }
        public double TotalPrice { get; set; }
    }
    public class ReceiptPostDTOValidator : AbstractValidator<ReceiptPostDTO>
    {
        public ReceiptPostDTOValidator()
        {
            RuleFor(x=>x.OrderId).NotNull().NotEmpty().GreaterThanOrEqualTo(1);
            RuleFor(x=>x.TotalPrice).NotNull().NotEmpty().GreaterThanOrEqualTo(0);
        }
    }
}
