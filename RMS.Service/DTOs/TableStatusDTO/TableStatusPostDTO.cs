using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.TableStatusDTO
{
    public class TableStatusPostDTO
    {
        public string Status { get; set; }
    }
    public class TableStatusPostDTOValidator : AbstractValidator<TableStatusPostDTO>
    {
        public TableStatusPostDTOValidator()
        {
            RuleFor(x => x.Status).MinimumLength(2).MaximumLength(20).NotNull();
        }
    }
}
