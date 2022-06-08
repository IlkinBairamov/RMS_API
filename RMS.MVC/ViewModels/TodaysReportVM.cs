using RMS.Service.DTOs.FoodDTO;
using System;
using System.Collections.Generic;

namespace RMS.MVC.ViewModels
{
    public class TodaysReportVM
    {
        public decimal Revenue { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal AverageRevenue { get; set; }
        public decimal ReceiptCount { get; set; }
        public decimal TotalReceiptCount { get; set; }
        public decimal Days { get; set; }
        public FoodReportDTO[] Foods { get; set; }
        public decimal[] revenuePerDay { get; set; }
        public decimal[] receiptPerDay{ get; set; }
    }
}
