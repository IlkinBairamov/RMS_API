using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RMS.MVC.ViewModels.Category
{
    public class CategoryCreateVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public IFormFile File { get; set; }
    }
}
