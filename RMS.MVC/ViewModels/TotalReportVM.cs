using RMS.Service.DTOs.FoodDTO;

namespace RMS.MVC.ViewModels
{
    public class TotalReportVM
    {
        public decimal TotalRevenue { get; set; }
        public decimal TotalReceiptCount { get; set; }
        public FoodReportDTO[] Foods { get; set; }
        public decimal[] revenuePerMonth { get; set; }
        public decimal[] receiptPerMonth { get; set; }
    }
}
