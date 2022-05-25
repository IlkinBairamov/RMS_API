using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RMS.MVC.ViewModels;
using RMS.MVC.ViewModels.Hall;
using RMS.MVC.ViewModels.Table;
using RMS.Service.DTOs.HallDTO;
using RMS.Service.DTOs.TableDTO;
using RMS.Service.Exceptions;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RMS.MVC.Controllers
{
    public class TableController : Controller
    {
        private readonly ITableService _tableService;
        private readonly IHallService _hallService;

        public TableController(ITableService tableService, IHallService hallService)
        {
            _tableService = tableService;
            _hallService = hallService;
        }

        public async Task<IActionResult> Index()
        {
            TableGetAllDTO tables = await _tableService.GetAllAsync();
            return View(tables);
        }

        public async Task<IActionResult> Create()
        {
            HallGetAllDTO halls = await _hallService.GetAllAsync();
            ViewBag.Halls = halls.Halls;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TablePostDTO tableDTO)
        {
            HallGetAllDTO halls = await _hallService.GetAllAsync();
            ViewBag.Halls = halls.Halls;
            try
            {
                await _tableService.CreateAsync(tableDTO);
            }
            catch (AlreadyExistException ex)
            {
                ModelState.AddModelError("Number",ex.Message);
                return View();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _tableService.Delete(id);
            return Json(new { status = 200 });
        }

        public async Task<IActionResult> Update(int id)
        {
            TableUpdateDTO tableDto = await _tableService.GetByIdAsync<TableUpdateDTO>(id);
            HallGetAllDTO halls = await _hallService.GetAllAsync();
            ViewBag.halls = halls.Halls;
            return View(tableDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, TableUpdateDTO tabledto)
        {
            HallGetAllDTO halls = await _hallService.GetAllAsync();
            ViewBag.Halls = halls.Halls;
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _tableService.EditAsync(id, tabledto);
            return RedirectToAction(nameof(Index));
        }
    }
}
