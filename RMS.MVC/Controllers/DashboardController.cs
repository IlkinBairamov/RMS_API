using Microsoft.AspNetCore.Mvc;
using RMS.Core.Entities;
using RMS.MVC.ViewModels;
using RMS.Service.DTOs.FoodDTO;
using RMS.Service.DTOs.ReceiptDTO;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RMS.MVC.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IReceiptService _receiptService;

        public DashboardController(IReceiptService receiptService)
        {
            _receiptService = receiptService;
        }
        public async Task<IActionResult> Index()
        {
            decimal TotalRevenue = 0;

            TotalReportVM ReportVM = new TotalReportVM();
            ReceiptGetAllDTO<Receipt> receipts = await _receiptService.GetAllAsync<Receipt>();
            List<FoodReportDTO> foodsList = await _receiptService.GetFoodsAsync();
            FoodReportDTO[] foods = foodsList.ToArray();
            Array.Sort(foods, new FoodComparer());
            Array.Reverse(foods);
            foreach (var item in receipts.Receipts)
            {
                TotalRevenue += item.TotalPrice;
            }
            ReportVM.TotalRevenue = TotalRevenue;
            ReportVM.TotalReceiptCount = receipts.Count;
            ReportVM.Foods = foods;
            return View(ReportVM);
        }
        public async Task<IActionResult> Daily()
        {
            decimal TodaysRevenue = 0;
            decimal TotalRevenue = 0;
            decimal TodaysReceiptCount = 0;

            List<DateTime> datesList = new List<DateTime>();

            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            TodaysReportVM todaysReportVM = new TodaysReportVM();
            ReceiptGetAllDTO<Receipt> receipts = await _receiptService.GetAllAsync<Receipt>();
            List<FoodReportDTO> foodsList = await _receiptService.GetFoodsAsync("daily");
            FoodReportDTO[] foods = foodsList.ToArray();
            Array.Sort(foods, new FoodComparer());
            Array.Reverse(foods);
            for (int i = 0; i < receipts.Receipts.Count; i++)
            {
                if (i == 0)
                {
                    datesList.Add(receipts.Receipts[0].Date.Date);
                }
                else
                {
                    if (receipts.Receipts[i].Date.Date != receipts.Receipts[i - 1].Date.Date)
                    {
                        datesList.Add(receipts.Receipts[i].Date.Date);
                    }
                }
                TotalRevenue += receipts.Receipts[i].TotalPrice;
                if (receipts.Receipts[i].Date.Date == date)
                {
                    TodaysReceiptCount++;
                    TodaysRevenue += receipts.Receipts[i].TotalPrice;
                }
            }
            var AverageRevenue = TotalRevenue / datesList.Count;
            todaysReportVM.Revenue = TodaysRevenue;
            todaysReportVM.AverageRevenue = AverageRevenue;
            todaysReportVM.TotalRevenue = TotalRevenue;
            todaysReportVM.ReceiptCount = TodaysReceiptCount;
            todaysReportVM.TotalReceiptCount = receipts.Count;
            todaysReportVM.Days = datesList.Count;
            todaysReportVM.Foods = foods;
            return View(todaysReportVM);
        }
        public async Task<IActionResult> Monthly()
        {
            decimal MonthlyRevenue = 0;
            decimal TotalRevenue = 0;
            decimal MonthlyReceiptCount = 0;

            List<int> datesList = new List<int>();

            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Month;
            TodaysReportVM todaysReportVM = new TodaysReportVM();
            ReceiptGetAllDTO<Receipt> receipts = await _receiptService.GetAllAsync<Receipt>();
            List<FoodReportDTO> foodsList = await _receiptService.GetFoodsAsync("monthly");
            FoodReportDTO[] foods = foodsList.ToArray();
            Array.Sort(foods, new FoodComparer());
            Array.Reverse(foods);
            for (int i = 0; i < receipts.Receipts.Count; i++)
            {
                if (i == 0)
                {
                    datesList.Add(receipts.Receipts[0].Date.Month);
                }
                else
                {
                    if (receipts.Receipts[i].Date.Month != receipts.Receipts[i - 1].Date.Month)
                    {
                        datesList.Add(receipts.Receipts[i].Date.Month);
                    }
                }
                TotalRevenue += receipts.Receipts[i].TotalPrice;
                if (receipts.Receipts[i].Date.Month == date)
                {
                    MonthlyReceiptCount++;
                    MonthlyRevenue += receipts.Receipts[i].TotalPrice;
                }
            }
            var AverageRevenue = TotalRevenue / datesList.Count;
            todaysReportVM.Revenue = MonthlyRevenue;
            todaysReportVM.AverageRevenue = AverageRevenue;
            todaysReportVM.TotalRevenue = TotalRevenue;
            todaysReportVM.ReceiptCount = MonthlyReceiptCount;
            todaysReportVM.TotalReceiptCount = receipts.Count;
            todaysReportVM.Days = datesList.Count;
            todaysReportVM.Foods = foods;
            return View(todaysReportVM);
        }
    }
    class FoodComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((FoodReportDTO)x).Amount,
                   ((FoodReportDTO)y).Amount);
        }
    }
}
