using FluentValidation;
using Microsoft.AspNetCore.Http;
using RMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.FoodDTO
{
    public class FoodPostDTO
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public IFormFile File { get; set; }
    }
    public class FoodPostDTOValidator : AbstractValidator<FoodPostDTO>
    {
        public FoodPostDTOValidator()
        {
            RuleFor(x => x.Name).MinimumLength(2).MaximumLength(50).NotNull();
            RuleFor(x => x.CategoryId).GreaterThanOrEqualTo(1).NotNull();
            RuleFor(x => x.File).NotNull();
        }
    }
}
