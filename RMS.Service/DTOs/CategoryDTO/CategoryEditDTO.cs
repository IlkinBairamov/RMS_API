using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.CategoryDTO
{
    public class CategoryEditDTO
    {
        public string Name { get; set; }
        public IFormFile File { get; set; }
    }

    public class CategoryEditDTOValidator : AbstractValidator<CategoryEditDTO>
    {
        public CategoryEditDTOValidator()
        {
            RuleFor(x => x.Name).MinimumLength(2).MaximumLength(50).NotNull();
        }
    }
}
