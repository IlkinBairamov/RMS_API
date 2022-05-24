using System.Collections.Generic;

namespace RMS.MVC.ViewModels.Hall
{
    public class HallIndexVM
    {
        public List<HallIndexItemVM> Halls { get; set; }
        public int Count { get; set; }
    }
    public class HallIndexItemVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
