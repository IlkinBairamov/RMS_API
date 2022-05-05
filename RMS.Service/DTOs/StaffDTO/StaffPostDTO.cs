using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.StaffDTO
{
    public class StaffPostDTO
    {
        public string FullName { get; set; }
        public int StaffTypeId { get; set; }
        public decimal Salary { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class StaffPostDTOValidator : AbstractValidator<StaffPostDTO>
    {
        public StaffPostDTOValidator()
        {
            RuleFor(x => x.FullName).MinimumLength(4).MaximumLength(50).NotNull().NotEmpty();
            RuleFor(x => x.StaffTypeId).GreaterThanOrEqualTo(1).NotNull().NotEmpty();
            RuleFor(x => x.Salary).GreaterThanOrEqualTo(300).NotEmpty().NotNull();
            RuleFor(x => x.PhoneNumber).MinimumLength(4).MaximumLength(50).NotEmpty();
        }
    }
}
