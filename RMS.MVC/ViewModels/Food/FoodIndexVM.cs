using System.Collections.Generic;

namespace RMS.MVC.ViewModels.Food
{
    public class FoodIndexVM
    {
        public List<FoodIndexItemVM> Items { get; set; }
        public int PageIndex { get; }
        public int TotalPages { get; }
        public bool HasNext { get; }
        public bool HasPrev { get; }
    }
    public class FoodIndexItemVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        //public List<ProductGetDTO> Products { get; set; }
        public string File { get; set; }
    }
}
