using Microsoft.AspNetCore.Mvc;
using RMS.Service.DTOs.CategoryDTO;
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
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            CategoryGetAllDTO<CategoryGetDTO> tables = await _categoryService.GetAllAsync<CategoryGetDTO>();
            return View(tables);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryPostDTO categoryDto)
        {
             if (!ModelState.IsValid)
            {
                return View();
            }
            await _categoryService.CreateAsync(categoryDto);
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.Delete(id);
            return Json(new { status = 200 });
        }

        public async Task<IActionResult> Update(int id)
        {
            CategoryEditDTO categoryDto = await _categoryService.GetByIdAsync<CategoryEditDTO>(id);
            return View(categoryDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, CategoryEditDTO categoryDto)
        {
            if (id == null)
            {
                return BadRequest();
            }
            await _categoryService.EditAsync(id, categoryDto);
            return RedirectToAction(nameof(Index));

        }
    }
}
