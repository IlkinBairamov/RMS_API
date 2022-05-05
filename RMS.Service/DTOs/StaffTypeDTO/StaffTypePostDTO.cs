using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.StaffTypeDTO
{
    public class StaffTypePostDTO
    {
        public string Name { get; set; }
    }
    public class StaffTypePostDTOValidator : AbstractValidator<StaffTypePostDTO>
    {
        public StaffTypePostDTOValidator()
        {
            RuleFor(x => x.Name).MinimumLength(4).MaximumLength(50).NotNull().NotEmpty();
        }
    }
}
