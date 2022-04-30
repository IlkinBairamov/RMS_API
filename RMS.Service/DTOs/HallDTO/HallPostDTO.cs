using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.HallDTO
{
    public class HallPostDTO
    {
        public string Name { get; set; }
    }
    class HallPostDTOValidator : AbstractValidator<HallPostDTO>
    {
        public HallPostDTOValidator()
        {
            RuleFor(x => x.Name).MinimumLength(2).MaximumLength(50);
        }
    }
}
