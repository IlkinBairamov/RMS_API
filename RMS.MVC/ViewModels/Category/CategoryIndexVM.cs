using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMS.MVC.ViewModels.Category
{
    public class CategoryIndexVM
    {
        public List<CategoryIndexItemVM> Categories { get; set; }   
        public int Count { get; set; }
    }

    public class CategoryIndexItemVM 
    {
        public int Id { get; set; }
        public string Name { get; set; }
       // public List<FoodGetDTO> Foods { get; set; }
    }
}
