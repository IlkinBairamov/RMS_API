using Microsoft.AspNetCore.Mvc;
using RMS.Service.DTOs;
using RMS.Service.DTOs.ReceiptDTO;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMS.MVC.Controllers
{
    public class ReceiptController : Controller
    {
        private readonly IReceiptService _receiptService;

        public ReceiptController(IReceiptService receiptService)
        {
            _receiptService = receiptService;
        }
        public async Task<IActionResult> Index()
        {
            ReceiptGetAllDTO<ReceiptGetDTO> receipts = await _receiptService.GetAllAsync<ReceiptGetDTO>();
            return View(receipts);
        }
        public async Task<IActionResult> Detail(int id)
        {
            ReceiptGetDTO receipt = await _receiptService.GetByIdAsync<ReceiptGetDTO>(id);
            return View(receipt);
        }
    }
}
