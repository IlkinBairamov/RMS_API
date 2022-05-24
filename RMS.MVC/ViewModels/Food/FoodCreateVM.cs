using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace RMS.MVC.ViewModels.Food
{
    public class FoodCreateVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public IFormFile File { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
