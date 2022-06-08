using Microsoft.AspNetCore.Mvc;
using RMS.Service.DTOs;
using RMS.Service.DTOs.CategoryDTO;
using RMS.Service.DTOs.FoodDTO;
using RMS.Service.Exceptions;
using RMS.Service.Services.Interfaces;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RMS.MVC.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodService _foodService;
        private readonly ICategoryService _categoryService;

        public FoodController(IFoodService foodService, ICategoryService categoryService)
        {
            _foodService = foodService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index(int pageIndex = 1,int count = 10)
        {
            PagenatedListDTO<FoodGetDTO> foods = await _foodService.GetAllFilteredAsync(pageIndex, count);
            return View(foods);
        }

        public async Task<IActionResult> Create()
        {
            CategoryGetAllDTO<CategoryGetDTO> categories = await _categoryService.GetAllAsync<CategoryGetDTO>();
            ViewBag.Categories = categories.Categories;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FoodPostDTO foodDto)
        {
            CategoryGetAllDTO<CategoryGetDTO> categories = await _categoryService.GetAllAsync<CategoryGetDTO>();
            ViewBag.Categories = categories.Categories;
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                await _foodService.CreateAsync(foodDto);
            }
            catch (AlreadyExistException ex)
            {
                ModelState.AddModelError("Name", ex.Message);
                return View();

            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _foodService.Delete(id);
            return Json(new { status = 200 });
        }

        public async Task<IActionResult> Update(int id)
        {
            CategoryGetAllDTO<CategoryGetDTO> categories = await _categoryService.GetAllAsync<CategoryGetDTO>();
            ViewBag.Categories = categories.Categories;
            FoodEditDTO foodDto = await _foodService.GetByIdAsync<FoodEditDTO>(id);
            return View(foodDto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id , FoodEditDTO foodDto) {
            CategoryGetAllDTO<CategoryGetDTO> categories = await _categoryService.GetAllAsync<CategoryGetDTO>();
            ViewBag.Categories = categories.Categories;
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _foodService.EditAsync(id, foodDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
