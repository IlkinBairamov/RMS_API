using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.FoodDTO
{
    public class FoodEditDTO
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public IFormFile File { get; set; }
    }
    public class FoodEditDTOValidator : AbstractValidator<FoodEditDTO>
    {
        public FoodEditDTOValidator()
        {
            RuleFor(x => x.Name).MinimumLength(2).MaximumLength(50).NotNull();
            RuleFor(x => x.CategoryId).GreaterThanOrEqualTo(1).NotNull();
        }
    }
}
